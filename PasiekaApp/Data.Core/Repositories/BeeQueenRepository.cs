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
    public class BeeQueenRepository : IBeeQueenRepository
    {
        private readonly BeeDbContext _db;
        public BeeQueenRepository(BeeDbContext beeDbContext)
        {
            _db = beeDbContext;
        }

        public BeeQueen Add(BeeQueen beeQueen)
        {
            _db.BeeQueens.Add(beeQueen);
            _db.SaveChanges();
            return beeQueen;
        }

        public bool Delete(BeeQueen beeQueen)
        {
            _db.BeeQueens.Remove(beeQueen);
            var changes = _db.SaveChanges();
            return changes == 1;
        }

        public BeeQueen Get(int id, bool includeRelations = false)
        {
            return _db.BeeQueens.FirstOrDefault(x => x.Id == id);

            //if (includeRelations)
            //{
            //return _db.BeeQueens.Include(x => x.Race).Include(x => x.Hive).Include(x => x.Race).FirstOrDefault(x => x.Id == id);
            //}
            //else
            //{
            //    return _db.BeeQueens.FirstOrDefault(x => x.Id == id);
            //}
        }

        public List<BeeQueen> GetAll()
        {
            return _db.BeeQueens.ToList();
        }

        public BeeQueen Update(BeeQueen beeQueen)
        {
            var trackedBeeQueen = _db.ChangeTracker.Entries<Race>()
                             .FirstOrDefault(e => e.Entity.Id == beeQueen.RaceId);

            if (trackedBeeQueen != null)
            {
                // Odłącz śledzoną instancję, aby uniknąć konfliktów
                _db.Entry(trackedBeeQueen.Entity).State = EntityState.Detached;
            }
            beeQueen.Race = _db.Races.First(x => x.Id == beeQueen.RaceId);
            _db.BeeQueens.Update(beeQueen);
            _db.SaveChanges();
            return beeQueen;
        }
    }
}
