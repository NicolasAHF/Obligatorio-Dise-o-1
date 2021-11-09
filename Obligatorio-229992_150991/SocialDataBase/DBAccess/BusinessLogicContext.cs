using DBStorage.DBAccess.EnititesDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBStorage.DBAccess
{
    public class BusinessLogicContext : DbContext
    {
        public BusinessLogicContext() : base("name = ConnString")
        {

        }

        public DbSet<UserEntityDTO> Users { get; set; }
        public DbSet<CategoryEntityDTO> Categories { get; set; }
        public DbSet<CreditCardEntityDTO> CreditCards { get; set; }
        public DbSet<PasswordEntityDTO> Passwords { get; set; }
        public DbSet<LeakedPasswordDTO> LeakedPasswords { get; set; }
        public DbSet<LeakedCreditCardDTO> LeakedCreditCards { get; set; }
        public DbSet<DataBreachDTO> DataBreaches { get; set; }
        public DbSet<DataBreachPool> DataBreachPool { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties<DateTime>().Configure(x => x.HasColumnType("datetime"));            
            modelBuilder.Entity<PasswordEntityDTO>().HasRequired(x => x.Category);
            modelBuilder.Entity<CreditCardEntityDTO>().HasRequired(x => x.Category);
            modelBuilder.Entity<DataBreachDTO>().HasRequired(x => x.Owner);
            modelBuilder.Entity<LeakedCreditCardDTO>().HasRequired(x => x.DataBreach);
            modelBuilder.Entity<LeakedPasswordDTO>().HasRequired(x => x.DataBreach);
            
            base.OnModelCreating(modelBuilder);
        }

    }
}
