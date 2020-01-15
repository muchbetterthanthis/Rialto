using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rialto.Data.Repositories;

namespace Rialto.EF.Repositories
{
    public class LotRepository
    {
        public LotRepository()
        { }
        public void CreateLot(Data.Entities.Lot lot)
        {
            using (var ctx = new RIaltoContext())
            {
                ctx._Lots.Add(lot);
                ctx.SaveChanges();
            }
        }

        public void UpdateLot(Data.Entities.Lot lot)
        {
            using (var ctx = new RIaltoContext())
            {
                ctx._Lots.Attach(lot);
                ctx.Entry(lot).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void DeleteLot(Data.Entities.Lot lot)
        {
            using (var ctx = new RIaltoContext())
            {
                ctx._Lots.Remove(lot);
                ctx.SaveChanges();
            }
        }
    }
}
