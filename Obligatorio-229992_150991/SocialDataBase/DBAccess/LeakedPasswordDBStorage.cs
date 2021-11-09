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
    public class LeakedPasswordDBStorage : IEntityLeaked<LeakedPasswordDTO>
    {
        public void Clear()
        {
            using (BusinessLogicContext context = new BusinessLogicContext())
            {
                context.LeakedPasswords.RemoveRange(context.LeakedPasswords);

                context.SaveChanges();
            }
        }

       public bool Exists(Guid Id)
        {
            using (BusinessLogicContext context = new BusinessLogicContext())
            {
                return context.LeakedPasswords.Any(c => c.ID == Id);
            }
        }
        public void Insert(LeakedPasswordDTO leakedPassword)
        {
            using (BusinessLogicContext context = new BusinessLogicContext())
            {                

                context.DataBreaches.Attach(leakedPassword.DataBreach);
                context.LeakedPasswords.Add(leakedPassword);

                context.SaveChanges();

            }
        }
        public bool IsEmpty()
        {
            using (BusinessLogicContext context = new BusinessLogicContext())
            {
                return !context.LeakedPasswords.Any();
            }
        }
        public LeakedPasswordDTO Get(Guid Id)
        {
            using (BusinessLogicContext context = new BusinessLogicContext())
            {
                LeakedPasswordDTO leakedPasswordRecord = context.LeakedPasswords.Include("DataBreach").FirstOrDefault(c => c.ID == Id);
                return leakedPasswordRecord;
            }
        }

        public IEnumerable<LeakedPasswordDTO> GetAllRecordByDataBreach(Guid ID)
        {
            using (BusinessLogicContext context = new BusinessLogicContext())
            {
                IEnumerable<LeakedPasswordDTO> allLeakedPwRecords = context.LeakedPasswords.Where(d => d.DataBreach.ID == ID).Include("DataBreach").ToList();

                return allLeakedPwRecords;
            }
        }
    }
}
