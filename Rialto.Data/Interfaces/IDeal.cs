using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rialto.Data.LotAgregate;
using System.Threading.Tasks;


namespace Rialto.Data.Interfaces
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