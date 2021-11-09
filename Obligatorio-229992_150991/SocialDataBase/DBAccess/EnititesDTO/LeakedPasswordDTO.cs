using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBStorage.DBAccess.EnititesDTO
{
    public class LeakedPasswordDTO
    {
        public Guid ID { get; set; }
        public string LeakedPasswordBody { get; set; }
        public DataBreachDTO DataBreach { get; set; }
        
    }
}
