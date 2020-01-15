using Rialto.Implementations;
using Rialto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rialto
{
    //public interface ICommandHandler {
    //     void ParseArguments(List<string> argumentsString);
    //     void Handle(); 
    // }

    // public class CommandHandler : ICommandHandler
    // {
    //     public void Handle()
    //     {

    //     }

    //     public void ParseArguments(List<string> argumentsString)
    //     {

    //     }
    // }

    //public interface ICommandHandlerFactory
    //{
    //    ICommandHandler create(string command);
    //}


    //public class CommandHandlerFactory : ICommandHandlerFactory
    //{
    //    private static Dictionary<string, Type> registeredCommands = {
    //        { "help", string },
    //        { }
    //    };


    //    public ICommandHandler create(string command)
    //    {
    //        var commandParts = command.Split(' ');
    //        var handler = Kernel.get(registeredCommands[commandParts[0]]) as ICommandHandler;

    //        if (commandParts.Count() > 1)
    //        {
    //            handler.ParseArguments(commandParts.Skip(1).ToList());
    //        }
    //        return handler;
    //    }
    //}
}



class Program
{
    static void Main(string[] args)
    {
        // фабрика что создает хэндлеры создаст консольный хэндрел и он вызывает метод хэндл

        //var commandText = Console.ReadLine();
        //var commandsFactory = new CommandFactory();

        //var handler = commandsFactory.create(commandText);
        ICommandHandlerFactory handlerFactory = new CommandHandlerFactory();
        ICommandHandler consoleCommandHandler = handlerFactory.Create("console_command_handler");

        //ConsoleUI int.show();
        consoleCommandHandler.Handle();
    }
}
