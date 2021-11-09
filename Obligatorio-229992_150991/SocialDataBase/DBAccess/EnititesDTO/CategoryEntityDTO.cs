using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBStorage.DBAccess.EnititesDTO
{
    public class CategoryEntityDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public UserEntityDTO Owner { get; set; }
        public ICollection<PasswordEntityDTO> Passwords { get; set; }
        public ICollection<CreditCardEntityDTO> CreditCards { get; set; }

    }
}
