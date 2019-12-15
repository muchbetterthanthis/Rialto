using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rialto.Data.Interfaces
{
    public interface ILot
    {
        int ID { get; set; }
        string Name { get; set; }
        float Price { get; set; }
        List<ILotDynamic> Dynamics { get; set; }

        void changePrice(float newPrice);
        double getProfit();
    }
}
