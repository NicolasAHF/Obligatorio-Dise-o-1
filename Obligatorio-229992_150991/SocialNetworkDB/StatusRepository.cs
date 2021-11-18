using SocialNetwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkDB
{
    public class StatusRepository
    {
        private Mapper mapper = new Mapper();

        public StatusRepository()
        {
        }

        public void Add(Status status)
        {
            using (SocialContext context = new SocialContext())
            {

                StatusEntity entity = mapper.StatusToEntity(status);
                context.StatusEntities.Add(entity);
                context.SaveChanges();
                status.Id = entity.Id;
            }
        }
        public void AddComment(Status status, Comment comment)
        {
            using (SocialContext context = new SocialContext())
            {
                StatusEntity entity = context.StatusEntities.Include("Comments").Where(p => p.Id == status.Id).FirstOrDefault<StatusEntity>(); ;
                entity.Comments.Add(mapper.CommentToEntity(comment));
                context.SaveChanges();
            }
        }
    }
}
