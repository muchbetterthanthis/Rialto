using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rialto.Data.Interfaces;

namespace Rialto.Data.Repositories
{
    public interface ILotRepository
    {
        void Create(ILot lot);
        void Update(ILot lot);
        ILot Get(int id);
        List<ILot> GetAllLots();
    }
}
