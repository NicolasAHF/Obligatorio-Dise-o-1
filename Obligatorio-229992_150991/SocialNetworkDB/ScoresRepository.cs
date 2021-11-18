using SocialNetwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkDB
{
    public class ScoresRepository
    {
        private Mapper mapper = new Mapper();
        public ScoresRepository()
        {
        }

        public void Add(GameScore score)
        {
            using (SocialContext context = new SocialContext())
            {
                GameScoreEntity entity = mapper.ScoreToEntity(score);
                context.Scores.Add(entity);
                context.SaveChanges();
                score.Id = entity.Id;
            }
        }
        public GameScore GetAll(String Username)
        {
            using (SocialContext context = new SocialContext())
            {
                GameScoreEntity entity = context.Scores.Where(u => u.Name == Username).FirstOrDefault<GameScoreEntity>();
                if (entity == null)
                {
                    throw new Exception("No se encontro");
                }

                GameScore score = mapper.EntityToScore(entity);
                return score;
            }
        }
        public bool IsEmpty()
        {
            using (SocialContext context = new SocialContext())
            {
                return context.Scores.Count() == 0;
            }
        }
    }
}
