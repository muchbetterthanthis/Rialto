using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rialto.Data.Interfaces;

namespace Rialto.Data.Entities.BetAgregate
{
    public class BetDynamic : ILotDynamic
    {
        public int ID { get; set; }
        public DateTime DateOfChange { get; set; }
        public float Price { get; set; }

        public BetDynamic(DateTime DateOfChange, float newPrice)
        {
            this.DateOfChange = DateOfChange;
            this.Price = newPrice;
        }
    }
}
