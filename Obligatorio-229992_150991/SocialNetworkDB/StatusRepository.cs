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
        public IEnumerable<Status> GetAll()
        {
            List<Status> statuses = new List<Status>();
            using (SocialContext context = new SocialContext())
            {
                foreach (StatusEntity entity in context.StatusEntities.ToList())
                {
                    statuses.Add(mapper.EntityToStatus(entity));
                }
            }
            return statuses;
        }
        public void AddReaction(Status status, Reaction reaction)
        {
            using (SocialContext context = new SocialContext())
            {
                StatusEntity entity = context.StatusEntities.Where(p => p.Id == status.Id).FirstOrDefault<StatusEntity>(); ;
                if (entity == null)
                {
                    throw new Exception("No se encontro");
                }
                entity.Reactions.Add(mapper.ReactionToEntity(reaction));
                context.SaveChanges();
            }
        }
        public void RemoveReaction(Status status, Reaction reaction)
        {
            using (SocialContext context = new SocialContext())
            {
                StatusEntity entity = context.StatusEntities.Where(p => p.Id == status.Id).FirstOrDefault<StatusEntity>(); ;
                if (entity == null)
                {
                    throw new Exception("No se encontro");
                }
                entity.Reactions.Remove(mapper.ReactionToEntity(reaction));
                context.SaveChanges();
            }
        }
        public bool IsEmpty()
        {
            using (SocialContext context = new SocialContext())
            {
                return context.StatusEntities.Count() == 0;
            }
        }
    }
}
