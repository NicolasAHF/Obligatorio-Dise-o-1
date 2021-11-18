using SocialNetwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkDB
{
    public class AlbumRepository
    {
        private Mapper mapper = new Mapper();

        public AlbumRepository()
        {
        }

        public void Add(Album album)
        {
            using (SocialContext context = new SocialContext())
            {

                AlbumEntity entity = mapper.AlbumToEntity(album);
                context.Albums.Add(entity);
                context.SaveChanges();
                album.Id = entity.Id;
            }
        }
        public void AddComment(Album album, Comment comment)
        {
            using (SocialContext context = new SocialContext())
            {
                AlbumEntity entity = context.Albums.Include("Comments").Where(p => p.Id == album.Id).FirstOrDefault<AlbumEntity>(); ;
                entity.Comments.Add(mapper.CommentToEntity(comment));
                context.SaveChanges();
            }
        }
        public IEnumerable<Album> GetAll()
        {
            List<Album> Albums = new List<Album>();
            using (SocialContext context = new SocialContext())
            {
                foreach (AlbumEntity entity in context.Albums.Include("Comments").Include("Photos").ToList())
                {
                    Albums.Add(mapper.EntityToAlbum(entity));
                }
            }
            return Albums;
        }
        public bool IsEmpty()
        {
            using (SocialContext context = new SocialContext())
            {
                return context.Albums.Count() == 0;
            }
        }
        public User GetUser(Album album)
        {
            using (SocialContext context = new SocialContext())
            {
                AlbumEntity entity = context.Albums.Include("UserEntity").Where(p => p.Id == album.Id).FirstOrDefault<AlbumEntity>(); ;
                UserEntity user = entity.UserEntity;
                return mapper.EntityToUser(user);
            }
        }
    }
}
