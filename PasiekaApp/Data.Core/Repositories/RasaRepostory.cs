using Data.Core.Models;
using Data.Core.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Repositories
{
    public class RasaRepostory : IRasaRepository
    {
        private readonly BeeDbContext _db;
        public RasaRepostory(BeeDbContext beeDbContext)
        {
            _db = beeDbContext;
        }

        public Race Add(Race ul)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Race Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Race> GetAll()
        {
            return _db.Rasas.ToList();
        }

        public Race Update(Race ul)
        {
            throw new NotImplementedException();
        }
    }
}
