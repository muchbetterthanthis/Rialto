using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rialto.Data.Entities.FutureAgregate;
using Rialto.Data.Interfaces;

namespace Rialto.Data.Entities
{
    public class Futures : ILot
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public List<ILotDynamic> Dynamics { get; set; }

        public void changePrice(float newPrice)
        {
            Dynamics.Add(new FutureDynamic(DateTime.Now, newPrice));
            this.Price = newPrice;
        }
        public double getProfit()
        {
            return Dynamics[0].Price - this.Price;
        }
    }
}
