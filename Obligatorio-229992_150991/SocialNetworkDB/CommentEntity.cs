using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkDB
{
    class CommentEntity : ContentEntity
    {
        public int Id { get; set; }
        public string TheComment { get; set; }
        public DateTime DateComment { get; set; }
        public UserEntity User { get; set; }
    }
}
