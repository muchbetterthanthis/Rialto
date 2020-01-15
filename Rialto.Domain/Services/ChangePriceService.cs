using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rialto.Data.Interfaces;
using Rialto.Domain.Interfaces;

namespace Rialto.Domain.Services
{
    public class ChangePriceService : IChangePriceService
    {
        private ILotRepository _lotRepository;

        public ChangePriceService(ILotRepository lotRepository) {
            _lotRepository = lotRepository;
        }

        public void changePrice()
        {
            List<ILot> lotsToChange = _lotRepository.GetAllLots();
            int randomLot = getRandomLotNumber(lotsToChange);

            lotsToChange[randomLot].changePrice(lotsToChange[randomLot].Price * 0.1F);
        }

        private int getRandomLotNumber(List<ILot> lotsToChange)
        {
            return new Random().Next(lotsToChange.Count);
        }
    }
}
