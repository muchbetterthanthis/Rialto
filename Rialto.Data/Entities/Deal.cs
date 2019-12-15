using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rialto.Data.Interfaces;

namespace Rialto.Data.Entities
{
    public class Deal
    {
        public int ID { get; set; }
        public ILot Lot { get; set; }
        public int NumberOfLots { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}
