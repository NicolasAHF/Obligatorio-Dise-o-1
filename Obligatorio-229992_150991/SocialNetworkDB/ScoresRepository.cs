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
    }
}
