using Rialto.Data.Entities;
using Rialto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rialto.Implementations
{
    public class LoginCommand : ICommand
    {
        public string Name { get; set; } = "login";
        public void Execute(params object[] parameters)
        {
            var menu = parameters[0] as UserConsoleMenu;

            if (menu == null)
            {
                return;
            }

            menu.setUser(new User());
        }
    }
}
