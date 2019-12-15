using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rialto.Data.Entities.LotAgregate;

namespace Rialto.Domain.Interfaces
{
    interface IAddLots
    {
        void addLot(Lot newLot);
    }
}
