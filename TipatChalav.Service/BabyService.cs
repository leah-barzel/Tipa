using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tipa.Core.repositories.services;
using Tipa.Data.Repository;
using TipatChalav;

namespace Tipa.Service
{
    public class BabyService :IBabyService
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

        public List<Baby> GetList()
        {
            throw new NotImplementedException();
        }

        IEnumerable<Baby> IBabyService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
