using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipatChalav.Controllers;

namespace Tipa.Core.services
{
    public interface INurseService
    {
        object add(Nurse nurse);
        void delete(int id);
        IEnumerable<Nurse> GetAll();
        object GetById(int id);
        List<Nurse> GetList();
        object Update(int id, Nurse updatedNurse);
    }
}
