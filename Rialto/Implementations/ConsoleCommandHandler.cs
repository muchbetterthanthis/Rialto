using Rialto.Data.Entities;
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
        private IMenu Menu { get; set; }
        public ConsoleCommandHandler(IMenu menu)
        {
            Menu = menu;
        }

        public void Handle()
        {
            ICommandFactory commandFactory = new CommandFactory();

            while (true)
            {
                Menu.Show();
                string userCommand = Console.ReadLine();

                if (userCommand == "login")
                {
                    commandFactory.CreateCommand(userCommand).Execute(Menu);
                }
                else
                {
                    commandFactory.CreateCommand(userCommand).Execute();
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
// в фабрику команд передается команд хэндлер
// меню - свойство, 
