using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tipa.Data.Repository;
using TipatChalav;

namespace Tipa.Service
{
    public class BabyService
    {
        private readonly IBabyRepository _babyRepository;

        public BabyService(IBabyRepository babyRepository)
        {
            _babyRepository = babyRepository;
        }
        public List<Baby> GetAll()
        {
            return _babyRepository.GetList();
        }
    }
}
