using SocialNetwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkDB
{
    class DirectionRepository
    {
        private Mapper mapper = new Mapper();

        public DirectionRepository()
        {
        }

        public void Add(Direction direction)
        {
            using (SocialContext context = new SocialContext())
            {

                DirectionEntity entity = mapper.DirectionToEntity(direction);
                context.Directions.Add(entity);
                context.SaveChanges();
                direction.Id = entity.Id;
            }
        }
        public void Update(Direction direction)
        {
            using (SocialContext context = new SocialContext())
            {
                DirectionEntity entity = context.Directions.Where(p => p.Id == direction.Id).FirstOrDefault<DirectionEntity>(); ;
                if (entity == null)
                {
                    throw new Exception("No se encontro");
                }
                entity.Id = direction.Id;
                context.SaveChanges();
            }
        }
    }
}
