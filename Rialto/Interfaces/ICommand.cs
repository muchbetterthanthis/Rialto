﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rialto.Interfaces
{
    public interface ICommand
    {
        string Name { get; set; }
        void Execute(params object[] parameters);
    }
}
