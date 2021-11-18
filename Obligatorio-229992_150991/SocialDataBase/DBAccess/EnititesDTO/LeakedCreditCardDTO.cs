using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBStorage.DBAccess.EnititesDTO
{
    public class LeakedCreditCardDTO
    {
        public Guid ID { get; set; }
        public string LeakedCreditCardNumber { get; set; }
        public DataBreachDTO DataBreach { get; set; }
    }
}
