using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rialto.Data.LotAgregate;
using Rialto.Data.Interfaces;

namespace Rialto.EF.Repositories
{
    public class LotRepository
    {
        public LotRepository()
        { }
        public void CreateLot(Data.LotAgregate.Lot lot)
        {
            using (var ctx = new RIaltoContext())
            {
                ctx._Lots.Add(lot);
                ctx.SaveChanges();
            }
        }

        public void UpdateLot(Data.LotAgregate.Lot lot)
        {
            using (var ctx = new RIaltoContext())
            {
                ctx._Lots.Attach(lot);
                ctx.Entry(lot).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void DeleteLot(Data.LotAgregate.Lot lot)
        {
            using (var ctx = new RIaltoContext())
            {
                ctx._Lots.Remove(lot);
                ctx.SaveChanges();
            }
        }

        public List<Rialto.Data.LotAgregate.Lot> GetAllLots()
        {
            using (var ctx = new RIaltoContext())
            {
                return ctx._Lots.ToList();
            }
        }
    }
}
