using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipatChalav.Controllers;
using TipatChalav;
using Tipa.Data.Repository;
using Tipa.Core.repositories;

namespace Tipa.Data.Repository
{
    public class NurseRepository : INurseRepository
    {
        private readonly DataContext _context;

        public NurseRepository(DataContext context)
        {
            _context = context;
        }

        public List<Nurse> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Nurse> GetList()
        {
            return _context.Nurses;

        }
    }

  
}
