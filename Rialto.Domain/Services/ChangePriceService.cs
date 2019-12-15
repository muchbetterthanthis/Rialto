using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rialto.Data.Entities.LotAgregate;
using Rialto.Domain.Interfaces;

namespace Rialto.Domain.Services
{
    //public class TestRepoImplementation : IRepository {
    //    getAllLosts() {
    //        return new List<>
    //    }
    //}

    public class ChangePriceService : IChangePriceService
    {
        //public ChangePriceService(IRepository repo) {
        //}

        public void changePrice(List<Lot> lotsToChange)
        {
            int randomLot = getRandomLotNumber(lotsToChange);

            lotsToChange[randomLot].changePrice(lotsToChange[randomLot].Price * 0.1F);
        }

        private int getRandomLotNumber(List<Lot> lotsToChange)
        {
            return new Random().Next(lotsToChange.Count);
        }
    }
}
