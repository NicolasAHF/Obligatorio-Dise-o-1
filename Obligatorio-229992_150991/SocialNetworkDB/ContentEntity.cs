using SocialNetwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkDB
{
    class ContentEntity
    {
        public int Id { get; set; }
        public ICollection<ReactionEntity> Reactions { get; set; }
        public ICollection<CommentEntity> Comments { get; set; }
    }
}
