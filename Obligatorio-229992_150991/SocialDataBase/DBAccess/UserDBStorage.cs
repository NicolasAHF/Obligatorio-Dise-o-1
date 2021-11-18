using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Entities;
using DBStorage.Interfaces;
using DBStorage.DBAccess.EnititesDTO;
using DBStorage.Exceptions;

namespace DBStorage.DBAccess
{
    public class UserDBStorage : IUserStorage
    {
        
        public bool Exists(Guid Id)
        {
            using(BusinessLogicContext context = new BusinessLogicContext())
            {
                return context.Users.Any(c => c.Id == Id);
            }
        }

        public User Get(Guid id)
        {
            using (BusinessLogicContext context = new BusinessLogicContext())
            {
                UserEntityDTO userRecord = context.Users.FirstOrDefault(c => c.Id == id);

                if (userRecord == null)
                {
                    throw new UserDBStorageException("Usuario no existe");
                }

                return ToBusinessLogicEntity(userRecord);
            }
        }

        public User ToBusinessLogicEntity(UserEntityDTO userRecord)
        {

            return new User(userRecord.Name, userRecord.MasterPassword)
            {
                Id = userRecord.Id
            };
            
        }

        public void Insert(User entity)
        {
            using (BusinessLogicContext context = new BusinessLogicContext())
            {
                if(context.Users.Any(c => c.Name == entity.Name))
                {
                    throw new UserDBStorageException("Nombre de usuario ya existe");
                }
                
                context.Users.Add(ToEntityDTO(entity));
                context.SaveChanges();
            }
        }

        public UserEntityDTO ToEntityDTO(User entity)
        {
            return new UserEntityDTO()
            {
                Id = entity.Id,
                Name = entity.Name,
                MasterPassword = entity.MasterPassword

            };
        }

        public bool IsEmpty()
        {
            using(BusinessLogicContext context = new BusinessLogicContext())
            {

                return !context.Users.Any();
            }
        }

        public void Clear()
        {
            using (BusinessLogicContext context = new BusinessLogicContext())
            {
                context.Users.RemoveRange(context.Users);
                context.SaveChanges();
            }
        }

        public IEnumerable<User> GetAllOthersUsers(Guid userId)
        {
            using(BusinessLogicContext context = new BusinessLogicContext())
            {
                IEnumerable<UserEntityDTO> allDBUserRecord = context.Users.Where(u=> u.Id != userId).ToList<UserEntityDTO>();
                List<User> allOthersUsers = new List<User>();

                foreach (UserEntityDTO user in allDBUserRecord)
                {
                    allOthersUsers.Add(ToBusinessLogicEntity(user));
                }

                return allOthersUsers;
            }
             
        }

        public User GetUserByName(string name)
        {
            using (BusinessLogicContext context = new BusinessLogicContext())
            {
                UserEntityDTO userToGet = context.Users.FirstOrDefault(u => u.Name == name);
                if (userToGet != null)
                {
                    return ToBusinessLogicEntity(userToGet);
                }else
                {
                    return null;
                }
                
            }
        }
    }
}
