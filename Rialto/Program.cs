using Rialto.Implementations;
using Rialto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        ICommandHandlerFactory handlerFactory = new CommandHandlerFactory();
        ICommandHandler consoleCommandHandler = handlerFactory.Create("console_command_handler");

        consoleCommandHandler.Handle();
    }
}
