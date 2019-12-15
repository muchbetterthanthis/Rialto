using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rialto.Data.Entities.LotAgregate
{
    public class LotDynamic
    {
        public int Id { get; set; }
        public DateTime DateOfChange { get; set; }
        public float Price { get; set; }

        public LotDynamic(DateTime DateOfChange, float Price)
        {
            this.DateOfChange = DateOfChange;
            this.Price = Price;
        }
    }
}
