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

        public Rasa Add(Rasa ul)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Rasa Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Rasa> GetAll()
        {
            throw new NotImplementedException();
        }

        public Rasa Update(Rasa ul)
        {
            throw new NotImplementedException();
        }
    }
}
