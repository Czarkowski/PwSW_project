using Data.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Repositories.Interfaces
{
    public interface IUlRepository
    {
        Ul Get(int id);
        List<Ul> GetAll();
        Ul Add(Ul ul);
        Ul Update(Ul ul);
        bool Delete(int id);
    }
}
