using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rialto.Data.Entities.LotAgregate
{
    public class Lot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        List<LotDynamic> Dynamics { get; set; }

        public Lot(int Id, string Name, float Price)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
        }

        public Lot() : this(-1, "Default Lot", 0F) { }

        public void changePrice(float newPrice)
        {
            Dynamics.Add(new LotDynamic(DateTime.Now, newPrice));
            this.Price = newPrice;
        }
    }
}
