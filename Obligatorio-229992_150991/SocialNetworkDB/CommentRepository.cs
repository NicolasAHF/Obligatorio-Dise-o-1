using SocialNetwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkDB
{
    public class CommentRepository
    {
        private Mapper mapper = new Mapper();
        public CommentRepository()
        {
        }

        public void Add(Comment comment)
        {
            using (SocialContext context = new SocialContext())
            {
                if (context.Comments.Any(c => c.Id == comment.Id))
                {
                    throw new Exception("El comment ya existe");
                }

                CommentEntity entity = mapper.CommentToEntity(comment);
                context.Comments.Add(entity);
                context.SaveChanges();
                comment.Id = entity.Id;
            }
        }
        public void AddComment(Comment mainComment, Comment comment)
        {
            using (SocialContext context = new SocialContext())
            {
                CommentEntity entity = context.Comments.Include("Comments").Where(p => p.Id == mainComment.Id).FirstOrDefault<CommentEntity>(); ;
                entity.Comments.Add(mapper.CommentToEntity(comment));
                context.SaveChanges();
            }
        }
    }
}
