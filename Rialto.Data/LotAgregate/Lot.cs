using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rialto.Data.LotAgregate
{
    public class Lot
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public List<LotDynamic> Dynamics { get; set; }

        public Lot(DateTime dateOfCreation, double initialPrice)
        {
            Dynamics.Add(new LotDynamic(dateOfCreation, initialPrice));
            Price = initialPrice;
        }

        public void changePrice(double newPrice)
        {
            Dynamics.Add(new LotDynamic(DateTime.Now, (newPrice - Dynamics[Dynamics.Count].Delta)));
            Price = newPrice;
        }

        public double getCurrentPrice()
        {
            return getPriceAtDate(DateTime.Now);
        }

        public double getPriceAtDate(DateTime atDate)
        {
            return Price + Dynamics.Where(x => x.DateOfChange <= atDate).Select(x => x.Delta).Sum();
        }
    }
}
