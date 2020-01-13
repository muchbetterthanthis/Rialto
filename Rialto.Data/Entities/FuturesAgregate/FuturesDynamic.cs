using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rialto.Data.Interfaces;

namespace Rialto.Data.Entities.FutureAgregate
{
    public class FutureDynamic : ILotDynamic
    {
        public int ID { get; set; }
        public DateTime DateOfChange { get; set; }
        public float Price { get; set; }

        public FutureDynamic(DateTime DateOfChange, float newPrice)
        {
            this.DateOfChange = DateOfChange;
            this.Price = newPrice;
        }
    }
}
