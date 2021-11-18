using SocialNetwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkDB
{
    class ReactionRepository
    {
        private Mapper mapper = new Mapper();

        public ReactionRepository()
        {
        }

        public void Add(Reaction reaction)
        {
            using (SocialContext context = new SocialContext())
            {

                ReactionEntity entity = mapper.ReactionToEntity(reaction);
                context.Reactions.Add(entity);
                context.SaveChanges();
                reaction.Id = entity.Id;
            }
        }
    }
}
