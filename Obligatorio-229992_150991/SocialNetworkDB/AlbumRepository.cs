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
    }
}
