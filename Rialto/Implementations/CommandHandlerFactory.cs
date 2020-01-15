using Rialto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rialto.Implementations
{
    public class CommandHandlerFactory : ICommandHandlerFactory
    {
        public ICommandHandler Create(string handlerName)
        {
            if (handlerName == "console_command_handler")
            {
                return new ConsoleCommandHandler(new UserMenu());
            }

            return null;
        }
    }
}
