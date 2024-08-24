using Data.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Repositories.Interfaces.BaseRepository
{
    public interface IBaseRepository<T>
    {
        T Get(int id);
        List<T> GetAll();
        T Add(T obj);
        T Update(T obj);
        bool Delete(T obj);
    }
}
