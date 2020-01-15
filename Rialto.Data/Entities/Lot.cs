using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rialto.Data.Interfaces;

namespace Rialto.Data.Entities
{
    public class Lot : ILot
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<ILotDynamic> Dynamics { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void changePrice(float newPrice)
        {
            throw new NotImplementedException();
        }

        public double getProfit()
        {
            throw new NotImplementedException();
        }
    }
}
