using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipatChalav;

namespace Tipa.Core.repositories.services
{
    public interface IBabyService
    {
        IEnumerable<Baby> GetAll();
        List<Baby> GetList();
    }
}
