using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBStorage.DBAccess.EnititesDTO
{
    public class UserEntityDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string MasterPassword { get; set; }
        public ICollection<CategoryEntityDTO> Categories { get;set; }
        public ICollection<DataBreachDTO> DataBreaches { get; set; }

    }
}
