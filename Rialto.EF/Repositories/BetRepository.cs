using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rialto.Data.Entities;

namespace Rialto.EF.Repositories
{
   public class BetRepository
    {
        public BetRepository()
        {
        }

        public void CreateBet(Data.Entities.Bet bet)
        {
            using (var ctx = new RIaltoContext())
            {
                ctx._Bets.Add(bet);
                ctx.SaveChanges();
            }
        }

        public void UpdateBet(Data.Entities.Bet bet)
        {
            using (var ctx = new RIaltoContext())
            {
                ctx._Bets.Attach(bet);
                ctx.Entry(bet).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void DeleteBet(Data.Entities.Bet bet)
        {
            using (var ctx = new RIaltoContext())
            {
                ctx._Bets.Remove(bet);
                ctx.SaveChanges();
            }
        }
    }
}
