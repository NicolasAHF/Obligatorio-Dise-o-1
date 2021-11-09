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
    public class CreditCardDBStorage : ICreditCardStorage
    {
        private CategoryDBStorage categoryStorage;
        
        public void Clear()
        {
            using (BusinessLogicContext context = new BusinessLogicContext())
            {
                context.CreditCards.RemoveRange(context.CreditCards);
                context.SaveChanges();
            }
        }

        public bool Exists(Guid Id)
        {
            using(BusinessLogicContext context = new BusinessLogicContext())
            {
                return context.CreditCards.Any(c => c.Id == Id);
            }
        }

        public CreditCard Get(Guid id)
        {
            using (BusinessLogicContext context = new BusinessLogicContext())
            {
                CreditCardEntityDTO creditCardRecord = context.CreditCards.Include(c=> c.Category).FirstOrDefault(c => c.Id == id);

                return ToBusinessLogicEntity(creditCardRecord);
            }
        }

        public IEnumerable<CreditCard> GetAllByCategory(Guid categoryId)
        {
            using (BusinessLogicContext context = new BusinessLogicContext())
            {
                IEnumerable<CreditCardEntityDTO> creditCardsRecord = context.CreditCards.Include(c=> c.Category).Where(c => c.Category.Id == categoryId).ToList();
                List<CreditCard> creditCards = new List<CreditCard>();

                foreach (CreditCardEntityDTO creditCard in creditCardsRecord)
                {
                    creditCards.Add(ToBusinessLogicEntity(creditCard));
                }

                return creditCards;
            }
        }

        private CreditCard ToBusinessLogicEntity(CreditCardEntityDTO creditCard)
        {
            categoryStorage = new CategoryDBStorage();
            Category category = categoryStorage.Get(creditCard.Category.Id);
            return new CreditCard(creditCard.Number, creditCard.CVVNumber, creditCard.ValidThrough, creditCard.OwnerName, creditCard.Type)
            {
                Id = creditCard.Id,
                Category = category,
                Note = creditCard.Note,
                Description = creditCard.Description,
                Leaked = creditCard.Leaked
            };
        }

        public void Insert(CreditCard entity)
        {
            using (BusinessLogicContext context = new BusinessLogicContext())
            {
                if(context.CreditCards.Any(c=> c.Id == entity.Id))
                {
                    throw new CreditCardDBStorageException("Esta tarjeta de credito ya existe");
                }

                CreditCardEntityDTO toAdd = ToEntityDTO(entity);
                context.Categories.Attach(toAdd.Category);                
                context.CreditCards.Add(toAdd);
                context.SaveChanges();
            }
        }

        private CreditCardEntityDTO ToEntityDTO(CreditCard entity)
        {
            categoryStorage = new CategoryDBStorage();
            CategoryEntityDTO category = categoryStorage.ToEntityDTO(entity.Category);
            return new CreditCardEntityDTO()
            {
                Id = entity.Id,
                Number = entity.Number,
                CVVNumber = entity.CVVNumber,
                ValidThrough = entity.ValidThrough,
                OwnerName = entity.OwnerName,
                Type = entity.Type,
                Note = entity.Note,
                Description = entity.Description,
                Category = category
            };
        }

        public bool IsEmpty()
        {
            using(BusinessLogicContext context = new BusinessLogicContext())
            {
                return !context.CreditCards.Any();
            }
        }

        public void Remove(Guid Id)
        {
            using (BusinessLogicContext context = new BusinessLogicContext())
            {
                CreditCardEntityDTO creditCardRecord = context.CreditCards.Find(Id);
                context.CreditCards.Remove(creditCardRecord);
                context.SaveChanges();
            }
        }

        public void Update(CreditCard entity)
        {
            
            using (BusinessLogicContext context = new BusinessLogicContext())
            {
                CreditCardEntityDTO creditCardRecord = context.CreditCards.FirstOrDefault(c => c.Id == entity.Id);
                if (creditCardRecord != null)
                {                    
                    creditCardRecord.Number = entity.Number;
                    creditCardRecord.CVVNumber = entity.CVVNumber;
                    creditCardRecord.ValidThrough = entity.ValidThrough;
                    creditCardRecord.OwnerName = entity.OwnerName;
                    creditCardRecord.Type = entity.Type;
                    creditCardRecord.Note = entity.Note;
                    creditCardRecord.CategoryId = entity.Category.Id;
                    creditCardRecord.Description = entity.Description;
                    creditCardRecord.Leaked = entity.Leaked;

                    context.SaveChanges();
                }

                //context.Categories.Attach(creditCardRecord.Category.Id);
                //context.Entry(creditCardRecord).State = EntityState.Modified;
                //context.SaveChanges();
            }
        }

        public IEnumerable<CreditCard> GetAllUserCreditCards(Guid userId)
        {
            IEnumerable<CreditCardEntityDTO> creditCardRecords = new List<CreditCardEntityDTO>();
            List<CreditCard> AllUserCreditCards = new List<CreditCard>();

            using (BusinessLogicContext context = new BusinessLogicContext())
            {
                creditCardRecords = context.CreditCards.Include(c=>c.Category).Where(c => c.Category.Owner.Id == userId).ToList();

                foreach(CreditCardEntityDTO creditCardRecord in creditCardRecords)
                {
                    AllUserCreditCards.Add(ToBusinessLogicEntity(creditCardRecord));
                }
            }
            return AllUserCreditCards;
        }
    }
}
