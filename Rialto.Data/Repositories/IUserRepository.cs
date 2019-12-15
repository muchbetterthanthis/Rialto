using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rialto.Data.Entities;

namespace Rialto.Data.Repositories
{
    public interface IUserRepository
    {
        List<Deal> GetAllDeals();
    }
}
