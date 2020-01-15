using Rialto.Interfaces;
using Rialto.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rialto.Implementations
{
    public class UserConsoleMenu : IMenu
    {
        private User _user;

        public void Show()
        {
            if (_user != null)
            {
                //Console.WriteLine("User {0} deals information", _user.Name);
                //foreach (IDeal deals in _user.Deals)
                //{
                //    int counter = 1;
                //    Console.WriteLine("Deal number {0}: {1} \n" +
                //        "Date of creation: {2}\n" +
                //        "Current PROFIT: {3}", counter, deals.Lot.Name, deals.DateOfCreation, deals.getProfit());
                //    Console.WriteLine("-------------------------------------------");
                //    counter += 1;
                //}
                Console.WriteLine("Hello motherfucker");
            }
            Console.Write("Enter your command: ");
        }

        public void setUser(User user)
        {
            _user = user;
        }
    }
}
