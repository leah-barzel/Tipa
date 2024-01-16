using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tipa.Core.repositories;
using Tipa.Core.services;
using Tipa.Data.Repository;
using TipatChalav;
using TipatChalav.Controllers;

namespace Tipa.Service
{
    public class NurseService : INurseService
    {
        private readonly INurseRepository _nurseRepository;

        public NurseService(INurseRepository nurseRepository)
        {
            _nurseRepository = nurseRepository;
        }

        public Nurse add(Nurse nurse)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Nurse> GetAll()
        {
            return _nurseRepository.GetList();
        }

        public object GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Nurse> GetList()
        {
            throw new NotImplementedException();
        }

        public object Update(int id, object name)
        {
            throw new NotImplementedException();
        }

        public object Update(int id, Nurse updatedNurse)
        {
            throw new NotImplementedException();
        }

        object INurseService.add(Nurse nurse)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Nurse> INurseService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
