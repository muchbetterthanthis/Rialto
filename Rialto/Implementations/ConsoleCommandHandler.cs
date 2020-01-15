using Rialto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rialto.Implementations
{
    public class ConsoleCommandHandler : ICommandHandler
    {
        private IMenu _menu;
        public ConsoleCommandHandler(IMenu menu)
        {
            _menu = menu;
        }

        public void Handle()
        {
            ICommandFactory commandFactory = new CommandFactory();
            while (true)
            {
                _menu.Show();
                string userCommand = Console.ReadLine();
                commandFactory.CreateCommand(userCommand).Execute();
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
