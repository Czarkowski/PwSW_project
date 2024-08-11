using Data.Core.Models;
using Data.Core.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Repositories
{
    public class UlRepository : IUlRepository
    {
        private readonly BeeDbContext _db;
        public UlRepository(BeeDbContext beeDbContext) 
        {
            _db = beeDbContext;
        }

        public Ul Add(Ul ul)
        {
            _db.Uls.Add(ul);
            _db.SaveChanges();
            return ul;
        }

        public bool Delete(int id)
        {
            _db.Uls.Remove(_db.Uls.FirstOrDefault(x => x.Id == id));
            return _db.SaveChanges() == 1;
        }

        public Ul Get(int id)
        {
            return _db.Uls.FirstOrDefault(x => x.Id == id);
        }

        public List<Ul> GetAll()
        {
            return _db.Uls.ToList();
        }

        public Ul Update(Ul ul)
        {
            _db.Uls.Update(ul);
            _db.SaveChanges();
            return ul;
        }
    }
}
