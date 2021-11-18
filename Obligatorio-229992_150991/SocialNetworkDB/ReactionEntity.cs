using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkDB
{
    class ReactionEntity
    {
        public int Id { get; set; }
        public string ReactionName { get; set; }
        public UserEntity User { get; set; }
    }
}
