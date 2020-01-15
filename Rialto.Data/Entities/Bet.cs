using Rialto.Data.LotAgregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rialto.Data.Interfaces;
using System.Threading.Tasks;

namespace Rialto.Data.Entities
{
    public class Bet : IDeal
    {
        public int ID { get; set; }
        public User User { get; set; }
        public Lot Lot { get; set; }
        public int NumberOfLots { get; set; }
        public DateTime DateOfCreation { get; set; }

        public double getProfit()
        {
            return Lot.getCurrentPrice() * NumberOfLots;
        }
    }
}