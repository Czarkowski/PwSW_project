using Data.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Repositories.Interfaces
{
    public interface IHiveRepository
    {
        Hive Get(int id);
        List<Hive> GetAll();
        Hive Add(Hive ul);
        Hive Update(Hive ul);
        bool Delete(int id);
    }
}
