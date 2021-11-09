using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBStorage.DBAccess.EnititesDTO
{
    public class PasswordEntityDTO
    {
        public Guid ID { get; set; }
        public string Site { get; set; }
        public CategoryEntityDTO Category { get; set; }
        public string Username { get; set; }
        public string PasswordBody { get; set; }
        public string Note { get; set; }
        public DateTime LastUpdate { get; set; }
        public string Strength { get; set; }
        public bool Leaked { get; set; }
        public Guid CategoryId {get;set;}
        
    }
}
