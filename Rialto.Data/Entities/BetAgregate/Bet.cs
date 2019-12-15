using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rialto.Data.Entities.BetAgregate;
using Rialto.Data.Interfaces;

namespace Rialto.Data.Entities
{
    public class Bet : ILot
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public List<ILotDynamic> Dynamics { get; set; }

        public void changePrice(float newPrice)
        {
            Dynamics.Add(new BetDynamic(DateTime.Now, newPrice));
            this.Price = newPrice;
        }
        public double getProfit()
        {
            return this.Price - Dynamics[0].Price;
        }
    }
}
