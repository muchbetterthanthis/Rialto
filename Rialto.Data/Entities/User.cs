using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rialto.Data.Entities
{
    public class User
    {
        public int ID { get; set; }
        public List<Bet> _Bets { get; set; }
        public List<Futures> _Futures { get; set; }
    }
}
