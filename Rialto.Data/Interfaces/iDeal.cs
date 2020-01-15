using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rialto.Data.LotAgregate;

namespace Rialto.Data.Entities
{
    public interface IDeal
    {
        int ID { get; set; }
        Lot Lot { get; set; }
        int NumberOfLots { get; set; }
        DateTime DateOfCreation { get; set; }

        double getProfit();
    }
}
