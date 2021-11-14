using SocialNetwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkDB
{
    public class GamesRepository
    {
        private Mapper mapper = new Mapper();
        public GamesRepository()
        {
        }

        public void Add(Game game)
        {
            using (SocialContext context = new SocialContext())
            {
                if (context.Games.Any(c => c.Name == game.Name))
                {
                    throw new Exception("El juego ya existe");
                }

                GameEntity entity = mapper.GameToEntity(game);
                context.Games.Add(entity);
                context.SaveChanges();
                game.Id = entity.Id;
            }
        }
        public Game Get(string game)
        {
            using (SocialContext context = new SocialContext())
            {
                GameEntity entity = context.Games.Where(p => p.Name == game).FirstOrDefault<GameEntity>();
                if (entity == null)
                {
                    throw new Exception("El juego no se encontro");
                }

                Game category = mapper.EntityToGame(entity);
                return category;
            }
        }
        public IEnumerable<Game> GetAll()
        {
            List<Game> games = new List<Game>();
            using (SocialContext context = new SocialContext())
            {
                foreach (GameEntity entity in context.Games.Include("Cover").ToList())
                {
                    games.Add(mapper.EntityToGame(entity));
                }
            }
            return games;
        }
        public void Delete(String gameName)
        {
            using (SocialContext context = new SocialContext())
            {
                GameEntity entity = context.Games.Where(p => p.Name == gameName).FirstOrDefault<GameEntity>(); ;
                if (entity != null)
                {
                    context.Games.Remove(entity);
                    context.SaveChanges();
                }
            }
        }
        public void UpdatePlayed(Game game)
        {
            using (SocialContext context = new SocialContext())
            {
                GameEntity entity = context.Games.Where(p => p.Name == game.Name).FirstOrDefault<GameEntity>(); ;
                if (entity == null)
                {
                    throw new Exception("No se encontro");
                }
                entity.Played = game.Played;
                context.SaveChanges();
            }
        }
    }
}
