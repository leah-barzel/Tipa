using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipatChalav.Controllers;

namespace Tipa.Core.repositories
{
    public interface INurseRepository
    {
        List<Nurse> GetAll();
        List<Nurse> GetList();
    }
}
