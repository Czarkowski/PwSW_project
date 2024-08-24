using Data.Core.Models;
using Data.Core.Repositories.Interfaces.BaseRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
        public BaseRepository(BeeDbContext beeDbContext, DbSet<T> dbSet)
        {
            _db = beeDbContext;
            _dbSet = dbSet;
        }
        protected BeeDbContext _db { get; set; }
        protected DbSet<T> _dbSet { get; set; }
        public T Add(T obj)
        {
            _dbSet.Add(obj);
            _db.SaveChanges();
            return obj;
        }

        public bool Delete(T obj)
        {
            _dbSet.Remove(obj);
            return _db.SaveChanges() == 1;
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T Get(int id)
        {
            return _dbSet.FirstOrDefault(x => x.Id == id);
        }

        public T Update(T obj)
        {
            _dbSet.Update(obj);
            _db.SaveChanges();
            return obj;
        }
    }
}
