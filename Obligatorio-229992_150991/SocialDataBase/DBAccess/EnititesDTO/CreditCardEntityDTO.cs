using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBStorage.DBAccess.EnititesDTO
{
    public class CreditCardEntityDTO
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public string CVVNumber { get; set; }
        public DateTime ValidThrough { get; set; }
        public string OwnerName { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public bool Leaked { get; set; }
        public CategoryEntityDTO Category { get; set; }
        public Guid CategoryId { get; set; }
        
    }
}
