using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rialto.Data.Entities;
using Rialto.Data.Repositories;
using Rialto.Domain.Interfaces;

namespace Rialto.Domain.Services
{
    public class ShowConsoleService : IShowService
    {
        private IUserRepository _userRepository;

        public ShowConsoleService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void show()
        {
            List<Deal> dealsToShow = _userRepository.GetAllDeals();

            foreach (Deal deal in dealsToShow)
            {
                Console.WriteLine("Deal {0}, current profit {1}", deal.Lot.Name, deal.Lot.getProfit());
            }
        }
    }
}
