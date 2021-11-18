using SocialNetwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkDB
{
    public class ListeningNowRepository
    {
        private Mapper mapper = new Mapper();

        public ListeningNowRepository()
        {
        }

        public void Add(ListeningNow song)
        {
            using (SocialContext context = new SocialContext())
            {

                ListeningNowEntity entity = mapper.ListeningNowToEntity(song);
                context.ListeningNows.Add(entity);
                context.SaveChanges();
                song.Id = entity.Id;
            }
        }
        public void UpdateComment(ListeningNow song, Comment comment)
        {
            using (SocialContext context = new SocialContext())
            {
                ListeningNowEntity entity = context.ListeningNows.Where(p => p.Id == song.Id).FirstOrDefault<ListeningNowEntity>(); ;
                if (entity == null)
                {
                    throw new Exception("No se encontro");
                }
                entity.Comments.Add(mapper.CommentToEntity(comment));
                context.SaveChanges();
            }
        }
    }
}
