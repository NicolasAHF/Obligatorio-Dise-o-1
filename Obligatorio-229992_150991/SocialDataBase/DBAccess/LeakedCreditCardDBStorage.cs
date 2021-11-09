using DBStorage.Interfaces;
using DBStorage.DBAccess.EnititesDTO;
using DBStorage.Exceptions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DBStorage.DBAccess
{
    public class LeakedCreditCardDBStorage : IEntityLeaked<LeakedCreditCardDTO>
    {
        public void Clear()
        {
            using(BusinessLogicContext context = new BusinessLogicContext())
            {
                context.LeakedCreditCards.RemoveRange(context.LeakedCreditCards);

                context.SaveChanges();
            }
        }

        public bool Exists(Guid Id)
        {
            using (BusinessLogicContext context = new BusinessLogicContext())
            {
                return context.LeakedCreditCards.Any(c => c.ID == Id);
            }
        }

        public LeakedCreditCardDTO Get(Guid id)
        {
            using (BusinessLogicContext context = new BusinessLogicContext())
            {
                LeakedCreditCardDTO leakedCreditCardRecord = context.LeakedCreditCards.Include("DataBreach").FirstOrDefault(c => c.ID == id);
                return leakedCreditCardRecord;
            }
        }

        public IEnumerable<LeakedCreditCardDTO> GetAllRecordByDataBreach(Guid ID)
        {
            using (BusinessLogicContext context = new BusinessLogicContext())
            {
                IEnumerable<LeakedCreditCardDTO> allLeakedCCRecords = context.LeakedCreditCards.Where(d => d.DataBreach.ID == ID).Include("DataBreach").ToList();
                
                return allLeakedCCRecords;
            }
            
        }

        public void Insert(LeakedCreditCardDTO leakedCreditCard)
        {
            using (BusinessLogicContext context = new BusinessLogicContext())
            {                
                context.DataBreaches.Attach(leakedCreditCard.DataBreach);
                context.LeakedCreditCards.Add(leakedCreditCard);

                context.SaveChanges();
            }
        }

        public bool IsEmpty()
        {
            using (BusinessLogicContext context = new BusinessLogicContext())
            {
                return !context.LeakedCreditCards.Any();
            }
        }

        
    }
}
