using SocialNetworkDB;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace SocialNetwork
{

    class SocialContext : DbContext
    {
        public SocialContext() : base("name=SocialDBConnection")
        {

        }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<PasswordEntity> Passwords { get; set; }
        public DbSet<AlbumEntity> Albums { get; set; }
        public DbSet<PhotoEntity> Photos { get; set; }
        public DbSet<DirectionEntity> Directions { get; set; }
        public DbSet<ListeningNowEntity> ListeningNows { get; set; }
        public DbSet<GameEntity> Games { get; set; }
        public DbSet<GameScoreEntity> Scores { get; set; }

    }
}