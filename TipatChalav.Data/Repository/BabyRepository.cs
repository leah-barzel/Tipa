using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baby.Data.Repository;
using TipatChalav;


namespace Tipa.Data.Repository
{
    public class BabyRepository : IBabyRepository
    {
        private readonly DataContext _context;
        public BabyRepository(DataContext context)
        {
            _context = context;
        }
        public List<Baby> GetList()
        {
            return _context.Babies;

        }
    }
}
