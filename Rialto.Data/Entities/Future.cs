using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rialto.Data.LotAgregate;

namespace Rialto.Data.Entities
{
    public class Futures : Deal
    {
        public DateTime DateOfSelling { get; set; }

        public override double getProfit()
        {
            return ( Lot.getPriceAtDate(DateTime.Now) - Lot.getPriceAtDate(DateOfCreation) ) * NumberOfLots;
        }
    }
}
