using Rialto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rialto.Implementations
{
    //todo enum
    public class CommandFactory : ICommandFactory
    {
        public ICommand CreateCommand(string commandName)
        {
            if (commandName == "show_hud")
            {
                return new ShowHudCommand();
            }
            if (commandName == "login")
            {
                return new LoginCommand();
            }
            else
            {
                return new NoSuchCommand();
            }
        }
    }
}
//сюда передавать хэндлер с менюшкой
//при создании команды ЛОГИН передавать менюшку в эту команду чтоб их связать
