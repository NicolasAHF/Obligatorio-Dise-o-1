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
    public class DataBreachDBStorage : IDataBreachReport
    {
        
        public void Clear()
        {
            using (BusinessLogicContext context = new BusinessLogicContext())
            {
                context.DataBreaches.RemoveRange(context.DataBreaches);

                context.SaveChanges();
            }
        }
        public void ClearDataBreachPool()
        {
            using(BusinessLogicContext context = new BusinessLogicContext())
            {
                context.DataBreachPool.RemoveRange(context.DataBreachPool);
                context.SaveChanges();
            }
        }

        public bool Exists(Guid Id)
        {
            using (BusinessLogicContext context = new BusinessLogicContext())
            {
                return context.DataBreaches.Any(c => c.ID == Id);
            }
        }

        public DataBreachDTO Get(Guid id)
        {
            using (BusinessLogicContext context = new BusinessLogicContext())
            {
                DataBreachDTO dataBreachRecord = context.DataBreaches.Include("Owner").FirstOrDefault(c => c.ID == id);
                return dataBreachRecord;
            }
        }

        public IEnumerable<DataBreachDTO> GetAllRecordsByUser(Guid ID)
        {
            ICollection<DataBreachDTO> allRecordsByUser = new List<DataBreachDTO>();
            using (BusinessLogicContext context = new BusinessLogicContext())
            {
                IEnumerable<DataBreachDTO> allDataBreaches = context.DataBreaches.Where(d => d.Owner.Id == ID).Include("Owner").ToList();
                foreach(DataBreachDTO db in allDataBreaches)
                {
                  
                  allRecordsByUser.Add(db);
                    
                }

            }
            return allRecordsByUser;
        }

        public void Insert(DataBreachDTO dataBreach)
        {
            using (BusinessLogicContext context = new BusinessLogicContext())
            {
                //if (this.Exists(dataBreach.ID))
                //{
                //    throw new DataBreachDBStorageException("Este Data Breach ya ha sido agregado");
                //}
                if (dataBreach == null)
                {
                    throw new DataBreachDBStorageException("El Data Breach no puede ser vacío");
                }
                context.Users.Attach(dataBreach.Owner);
                context.DataBreaches.Add(dataBreach);

                context.SaveChanges();

            }
        }

        public bool IsEmpty()
        {
            using (BusinessLogicContext context = new BusinessLogicContext())
            {
                return !context.DataBreaches.Any();
            }
        }

        public ICollection<DataBreachPool> GetPool()
        {
            ICollection<DataBreachPool> allItems = new List<DataBreachPool>();
            using(BusinessLogicContext context = new BusinessLogicContext())
            {
                allItems = context.DataBreachPool.ToList();
            }

            return allItems;
        }

        public void AddItem(string item)
        {
            DataBreachPool itemPool = new DataBreachPool() { Id = Guid.NewGuid(), LeakedItem = item };
            using(BusinessLogicContext context = new BusinessLogicContext())
            {
                if (context.DataBreachPool.Any(i => i.LeakedItem == item)){
                    throw new DataBreachPoolException("este item ya se encuentra en el pool");
                }
                context.DataBreachPool.Add(itemPool);
                context.SaveChanges();
            }
        }
    }
}
