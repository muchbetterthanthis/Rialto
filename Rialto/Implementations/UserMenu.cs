using Rialto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rialto.Implementations
{
    public class UserMenu : IMenu
    {
        public void Show()
        {
            Console.WriteLine("1) Go to hell \n Write your command: ");
        }
    }
}
