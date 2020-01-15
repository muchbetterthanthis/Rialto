using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rialto.Data.Entities.BetAgregate;
using Rialto.Data.Interfaces;

namespace Rialto.Data.Entities
{
    public class Bet 
    {
        public int ID { get; set; }
        public Lot Lot { get; set; }
    }
}
