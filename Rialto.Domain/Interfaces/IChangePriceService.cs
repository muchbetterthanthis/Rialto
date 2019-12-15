using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rialto.Data.Entities.LotAgregate;

namespace Rialto.Domain.Interfaces
{
    public interface IChangePriceService
    {
        void changePrice(List<Lot> lotsToChange);
    }
}
