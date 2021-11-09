using System;

using System.Data.Entity;


namespace SocialNetwork
{

    public class SocialContext : DbContext
    {
        public SocialContext() : base("name=SocialDBConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Password> Passwords { get; set; }
        public DbSet<Album> Albunes { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}