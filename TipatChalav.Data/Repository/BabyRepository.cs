﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public List<Baby> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Baby> GetList()
        {
            return _context.Babies;

        }
    }
}
