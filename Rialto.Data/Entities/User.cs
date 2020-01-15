using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rialto.Data.Interfaces;

namespace Rialto.Data.Entities
{
    public class User
    {
        public int ID { get; set; }
        public List<IDeal> Deals { get; set; }
    }
}
