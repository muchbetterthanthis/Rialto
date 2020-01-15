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
    class RIaltoContext
    {
        public RIaltoContext() : base("DbConnection")
        { }
        public DbSet<Bet> Bets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Lot> Lots { get; set; }
        public DbSet<Futures> _Futers { get; set; }
        public DbSet<FuturesDynamic> _FuturesDynamics { get; set; }
        public DbSet<BetDynamic> _BetDynamics { get; set; }

    }
}
