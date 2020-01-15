using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rialto.EF.Repositories
{
    public class UserRepository
    {
        public UserRepository()
        { }
        public void CreateUser(Data.Entities.User user)
        {
            using (var ctx = new RIaltoContext())
            {
                ctx._Users.Add(user);
                ctx.SaveChanges();
            }
        }

        public void UpdateUser(Data.Entities.User user)
        {
            using (var ctx = new RIaltoContext())
            {
                ctx._Users.Attach(user);
                ctx.Entry(user).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void DeleteUser(Data.Entities.User user)
        {
            using (var ctx = new RIaltoContext())
            {
                ctx._Users.Remove(user);
                ctx.SaveChanges();
            }
        }

        public Rialto.Data.Entities.User GetUser(int id)
        {
            using (var ctx = new RIaltoContext())
            {
                return ctx._Users.FirstOrDefault(r => r.ID == id);
            }
        }

        public List<Rialto.Data.Entities.Bet> GetAllBets(int id)
        {
                using (var ctx = new RIaltoContext())
                {
                  return ctx._Users.FirstOrDefault(i => i.ID == id)._Bets;
                }
        }

        public List<Rialto.Data.Entities.Futures> GetAllFuters(int id)
        {
            using (var ctx = new RIaltoContext())
            {
                return ctx._Users.FirstOrDefault(i => i.ID == id)._Futures;
            }
        }
    }
}
