using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBStorage.DBAccess.EnititesDTO
{
    public class DataBreachDTO
    {
        public Guid ID { get; set; }
        public DateTime LastUpdate { get; set; }
        public UserEntityDTO Owner { get; set; }
        public ICollection<LeakedCreditCardDTO> LeakedCreditCards { get; set; }
        public ICollection<LeakedCreditCardDTO> LeakedPasswords { get; set; }
    }
}
