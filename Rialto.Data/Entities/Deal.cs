using Rialto.Data.Entities.LotAgregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rialto.Data.Entities
{
    public abstract class Deal
    {
        public int id { get; set; }
        public Lot LotForSale { get; set; }
        public DateTime DateOfCreation { get; set; }
        public double NumberOfLots { get; set; }
    }
}
