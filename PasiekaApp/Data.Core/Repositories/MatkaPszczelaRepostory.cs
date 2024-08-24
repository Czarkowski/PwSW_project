using Data.Core.Models;
using Data.Core.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Repositories
{
    public class MatkaPszczelaRepostory : IMatkaPszczelaRepository
    {
        private readonly BeeDbContext _db;
        public MatkaPszczelaRepostory(BeeDbContext beeDbContext)
        {
            _db = beeDbContext;
        }

        public BeeQueen Add(BeeQueen beeQueen)
        {
            _db.MatkaPszczelas.Add(beeQueen);
            _db.SaveChanges();
            return beeQueen;
        }

        public bool Delete(BeeQueen beeQueen)
        {
            _db.MatkaPszczelas.Remove(beeQueen);
            var changes = _db.SaveChanges();
            return changes == 1;
        }

        public BeeQueen Get(int id, bool includeRelations = false)
        {
            if (includeRelations)
            {
                return _db.MatkaPszczelas.Include(x => x.Race).Include(x => x.Hive).FirstOrDefault(x => x.Id == id);
            }
            else
            {
                return _db.MatkaPszczelas.FirstOrDefault(x => x.Id == id);
            }
        }

        public List<BeeQueen> GetAll()
        {
            return _db.MatkaPszczelas.ToList();
        }

        public BeeQueen Update(BeeQueen beeQueen)
        {
            _db.MatkaPszczelas.Update(beeQueen);
            _db.SaveChanges();
            return beeQueen;
        }
    }
}
