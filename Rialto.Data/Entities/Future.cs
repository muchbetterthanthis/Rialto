using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rialto.Data.LotAgregate;

namespace Rialto.Data.Entities
{
    public class Futures : IDeal
    {
        public int ID { get; set; }
        public Lot Lot { get; set; }
        public int NumberOfLots { get; set; }
        public DateTime DateOfCreation { get; set; }

        public DateTime DateOfSelling { get; set; }

        public double getProfit()
        {
            return ( Lot.getPriceAtDate(DateTime.Now) - Lot.getPriceAtDate(DateOfCreation) ) * NumberOfLots;
        }
    }
}
