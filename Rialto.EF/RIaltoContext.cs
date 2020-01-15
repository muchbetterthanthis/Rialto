using System;
using System.Collections.Generic;
using System.Linq;
using Rialto.Data.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Text;
using System.Threading.Tasks;
using Rialto.Data.Entities.FutureAgregate;
using Rialto.Data.Entities.BetAgregate;

namespace Rialto.EF
{
    class RIaltoContext : DbContext
    {
        public RIaltoContext() : base("DbConnection")
        { }
       
        public DbSet<Bet> _Bets { get; set; }
        public DbSet<User> _Users { get; set; }
        public DbSet<Lot> _Lots { get; set; }
        public DbSet<Futures> _Futers { get; set; }
       public DbSet<LotDynamic> lotDynamics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Lot>().HasMany(t => t.Dynamics).WithRequired(c => c.Lot);
            modelBuilder.Entity<Futures>().HasRequired(x => x.Lot);
            modelBuilder.Entity<Bet>().HasRequired(z => z.Lot);
            modelBuilder.Entity<User>().HasRequired(h=>h._Bets).

        }
    }
}
