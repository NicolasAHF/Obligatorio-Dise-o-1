using System.Data.Entity;
using SocialNetwork;

namespace SocialDataBase
{

    public class SocialContext : DbContext
        {
            public SocialContext() : base("name=SocialDBConnectionString")


        {
              //  Database.SetInitializer<SocialContext>(new SocialDBInitializer());
            }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {

            }

            public DbSet<User> Users { get; set; }
         //   public DbSet<Password> Passwords { get; set; }
          //  public DbSet<Photo> Photos { get; set; }



    }
}
