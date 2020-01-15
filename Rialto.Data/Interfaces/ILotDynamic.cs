using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rialto.Data.Entities;

namespace Rialto.Data.Interfaces
{
    public interface ILotDynamic
    {
        int ID { get; set; }
        Lot Lot { get; set; }
        DateTime DateOfChange { get; set; }
        float Price { get; set; }
    }
}
