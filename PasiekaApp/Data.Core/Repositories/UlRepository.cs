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

        public Hive Add(Hive ul)
        {
            _db.Hives.Add(ul);
            _db.SaveChanges();
            return ul;
        }

        public bool Delete(int id)
        {
            _db.Hives.Remove(_db.Hives.FirstOrDefault(x => x.Id == id));
            return _db.SaveChanges() == 1;
        }

        public Hive Get(int id)
        {
            return _db.Hives.FirstOrDefault(x => x.Id == id);
        }

        public List<Hive> GetAll()
        {
            return _db.Hives.ToList();
        }

        public Hive Update(Hive ul)
        {
            _db.Hives.Update(ul);
            _db.SaveChanges();
            return ul;
        }
    }
}
