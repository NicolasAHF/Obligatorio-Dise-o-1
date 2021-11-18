using BusinessLogic.Entities;
using DBStorage.Interfaces;
using DBStorage.DBAccess.EnititesDTO;
using DBStorage.Exceptions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBStorage.DBAccess
{
    public class PasswordDBStorage : IPasswordStorage
    {
        private CategoryDBStorage categoryStorage;
        public void Clear()
        {
            using(BusinessLogicContext context = new BusinessLogicContext())
            {
                context.Passwords.RemoveRange(context.Passwords);
                context.SaveChanges();
            }
        }

        public bool Exists(Guid Id)
        {
           using (BusinessLogicContext context = new BusinessLogicContext())
            {
                return context.Passwords.Any(p => p.ID == Id);
            }
        }

        public Password Get(Guid id)
        {
            using (BusinessLogicContext context = new BusinessLogicContext())
            {
                PasswordEntityDTO passwordRecord = context.Passwords.Include("Category").FirstOrDefault(p => p.ID == id);

                return ToBusinessLogicEntity(passwordRecord);
            }
        }

        private Password ToBusinessLogicEntity(PasswordEntityDTO passwordRecord)
        {
            categoryStorage = new CategoryDBStorage();
            Category category = categoryStorage.Get(passwordRecord.Category.Id);
            return new Password(passwordRecord.Site, passwordRecord.Username, passwordRecord.PasswordBody)
            {
                ID = passwordRecord.ID,
                Category = category,
                Leaked = passwordRecord.Leaked,
                Strength = passwordRecord.Strength,
                LastUpdate = passwordRecord.LastUpdate,
                Note = passwordRecord.Note
            };
        }

        public IEnumerable<Password> GetAllByCategory(Guid categoryId)
        {
            using (BusinessLogicContext context = new BusinessLogicContext())
            {
                IEnumerable<PasswordEntityDTO> passwordEntities = context.Passwords.Where(p => p.Category.Id == categoryId).Include("Category").ToList();
                List<Password> passwords = new List<Password>();

                foreach(PasswordEntityDTO password in passwordEntities)
                {
                    passwords.Add(ToBusinessLogicEntity(password));
                }

                return passwords;
            }
        }

        public IEnumerable<Password> GetAllUserPasswords(Guid userId)
        {
            IEnumerable<PasswordEntityDTO> passwordRecords = new List<PasswordEntityDTO>();
            List<Password> AllUserPasswords = new List<Password>();

            using (BusinessLogicContext context = new BusinessLogicContext())
            {
                passwordRecords = context.Passwords.Where(c => c.Category.Owner.Id == userId).Include("Category").ToList();

                foreach (PasswordEntityDTO passwordRecord in passwordRecords)
                {
                    AllUserPasswords.Add(ToBusinessLogicEntity(passwordRecord));
                }
            }
            return AllUserPasswords;
        }

        public void Insert(Password entity)
        {
            using(BusinessLogicContext context = new BusinessLogicContext())
            {
                if (context.Passwords.Any(p=> p.ID == entity.ID))
                {
                    throw new PasswordBDStorageException("Contraseña ya existe");
                }
                PasswordEntityDTO toAdd = ToEntityDTO(entity);
                context.Categories.Attach(toAdd.Category);
                context.Passwords.Add(toAdd);
                context.SaveChanges();
            }
        }

        private PasswordEntityDTO ToEntityDTO(Password entity)
        {
            using (BusinessLogicContext context = new BusinessLogicContext())
            {
                categoryStorage = new CategoryDBStorage();
                CategoryEntityDTO category = categoryStorage.ToEntityDTO(entity.Category);
                return new PasswordEntityDTO()
                {
                    ID = entity.ID,
                    Site = entity.Site,
                    PasswordBody = entity.PasswordBody,
                    Username = entity.Username,
                    LastUpdate = entity.LastUpdate,
                    Strength = entity.Strength,
                    Category = category,
                    Leaked = entity.Leaked,
                    Note = entity.Note
                };
            }
        }

        public bool IsEmpty()
        {
            using (BusinessLogicContext context = new BusinessLogicContext())
            {
                return !context.Passwords.Any();
            }
        }

        public void Remove(Guid Id)
        {
            using(BusinessLogicContext context = new BusinessLogicContext())
            {
                PasswordEntityDTO passwordRecord = context.Passwords.FirstOrDefault(p => p.ID == Id);
                context.Passwords.Remove(passwordRecord);
                context.SaveChanges();
            }
        }

        public void Update(Password entity)
        {
            categoryStorage = new CategoryDBStorage();
            
            using (BusinessLogicContext context = new BusinessLogicContext())
            {
                PasswordEntityDTO passwordRecord = context.Passwords.First(p => p.ID == entity.ID);
                passwordRecord.CategoryId = entity.Category.Id;
                passwordRecord.PasswordBody = entity.PasswordBody;
                passwordRecord.Site = entity.Site;
                passwordRecord.Username = entity.Username;
                passwordRecord.LastUpdate = entity.LastUpdate;
                passwordRecord.Note = entity.Note;
                passwordRecord.Strength = entity.Strength;
                passwordRecord.Leaked = entity.Leaked;

                context.SaveChanges();
            }
        }

        public string GetUserKey(Guid userId)
        {            
            using (BusinessLogicContext context = new BusinessLogicContext())
            {
                UserEntityDTO userRecord = context.Users.First(u => u.Id == userId);
                return userRecord.MasterPassword;
            }
        }
    }
}
