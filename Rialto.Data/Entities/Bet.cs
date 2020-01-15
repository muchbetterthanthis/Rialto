using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rialto.Data.Entities
{
    public class Bet : Deal
    {
        public override double getProfit()
        {
            return Lot.getCurrentPrice() * NumberOfLots;
        }
    }
}
