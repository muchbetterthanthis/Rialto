using System;
using System.Collections.Generic;
using System.Linq;
using Rialto.Data.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Text;
using System.Threading.Tasks;
using Rialto.Data.LotAgregate;
using Rialto.Data.Interfaces;


namespace Rialto.EF
{
    class RIaltoContext : DbContext
    {
        
       
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
            modelBuilder.Entity<User>().HasMany(h => h._Bets).WithRequired(j => j.User);
            modelBuilder.Entity<User>().HasMany(u => u._Futures).WithRequired(i => i.User);
        }
    }
}
