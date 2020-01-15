
namespace Rialto.EF.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using Rialto.Data.Entities;
    using Rialto.Data.Interfaces;
    using Rialto.Data.LotAgregate;
    using Rialto.EF.Repositories;
    internal sealed class Configuration : DbMigrationsConfiguration<Rialto.EF.RIaltoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Rialto.EF.RIaltoContext context)
        {
            context._Lots.AddOrUpdate(
                new Lot
                {
                    ID = 1,
                    Name = "Apple inc.",
                    Price = 250.02,
                    Dynamics = null
                },
                new Lot
                {
                    ID = 2,
                    Name = "Google",
                    Price = 213.1,
                    Dynamics = null
                },
                new Lot
                {
                    ID = 3,
                    Name = "Dow Jones",
                    Price = 178.89,
                    Dynamics = null
                },
                new Lot
                {
                    ID = 4,
                    Name = "General Electric",
                    Price = 11.94,
                    Dynamics = null
                }
                );
            context._Users.AddOrUpdate(
                new User
                {
                    ID = 1,
                    _Bets = null,
                    _Futures = null
                }
                );
            context._Bets.AddOrUpdate(
                new Bet
                {
                    ID=1,
                    Lot = context._Lots.Find(1),
                    NumberOfLots = 20,
                    User = context._Users.Find(1),
                    DateOfCreation = DateTime.Today
                }
                );
        }
    }
}
