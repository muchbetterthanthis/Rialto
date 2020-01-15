using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rialto.EF.Repositories
{
    public class FutersRepository
    {
        public FutersRepository()
        {
        }

        public void CreateFuters(Data.Entities.Futures futures)
        {
            using (var ctx = new RIaltoContext())
            {
                ctx._Futers.Add(futures);
                ctx.SaveChanges();
            }
        }

        public void UpdateFuters(Data.Entities.Futures futures)
        {
            using (var ctx = new RIaltoContext())
            {
                ctx._Futers.Attach(futures);
                ctx.Entry(futures).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void DeleteFuters(Data.Entities.Futures futures)
        {
            using (var ctx = new RIaltoContext())
            {
                ctx._Futers.Remove(futures);
                ctx.SaveChanges();
            }
        }
    }
}
