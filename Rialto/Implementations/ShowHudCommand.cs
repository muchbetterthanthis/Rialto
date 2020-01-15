using Rialto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rialto.Implementations
{
    public class ShowHudCommand : ICommand
    {
        public string Name { get; set; } = "show_hud";

        public void Execute()
        {
            Console.WriteLine("***I'M SHOWING HUD***");
        }
    }
}
