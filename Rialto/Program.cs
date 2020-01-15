using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rialto
{
    interface ICommandHandler {
        void ParseArguments(List<string> argumentsString);
        void Handle(); 
    }

    public class CommandHandler : ICommandHandler
    {
        public void Handle()
        {
            
        }

        private void ParseArguments(List<string> argumentsString)
        {
            
        }
    }

    interface ICommandFactory {
        ICommandHandler create(string command);
    }


    public class CommandFactory : ICommandFactory
    {
        private static Dictionary<string, Type> registeredCommands = {
            { "cet", typeof(ShowCommand) }
        };


        public ICommandHandler create(string command)
        {
            var commandParts = command.Split(' ');
            var handler = Kernel.get(registeredCommands[commandParts[0]]) as ICommandHandler;

            if (commandParts.Count() > 1)
            {
                handler.ParseArguments(commandParts.Skip(1).ToList());
            }
            return handler;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                var commandText = Console.ReadLine();
                var commandsFactory = new CommandFactory();

                var handler = commandsFactory.create(commandText);
                handler.Handle();
            }
        }
    }
}
