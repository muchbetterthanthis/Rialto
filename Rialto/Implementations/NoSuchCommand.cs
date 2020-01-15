using Rialto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rialto.Implementations
{
    public class NoSuchCommand : ICommand
    {
        public string Name { get; set; } = "no_such_command";

        public void Execute(params object[] parameters)
        {
            Console.WriteLine("No such command found");
        }
    }
}
