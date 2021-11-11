using SocialNetwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkDB
{
    class PhotoRepository
    {
        private Mapper mapper = new Mapper();

        public PhotoRepository()
        {
        }

        public void Add(Photo photo)
        {
            using (SocialContext context = new SocialContext())
            {

                PhotoEntity entity = mapper.PhotoToEntity(photo);
                context.Photos.Add(entity);
                context.SaveChanges();
                photo.Id = entity.Id;
            }
        }
        public void Update(Photo photo)
        {
            using (SocialContext context = new SocialContext())
            {
                PhotoEntity entity = context.Photos.Where(p => p.Id == photo.Id).FirstOrDefault<PhotoEntity>(); ;
                if (entity == null)
                {
                    throw new Exception("No se encontro");
                }
                entity.Id = photo.Id;
                context.SaveChanges();
            }
        }
    }
}
