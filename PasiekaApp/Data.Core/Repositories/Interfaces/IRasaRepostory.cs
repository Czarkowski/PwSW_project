using Data.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Repositories.Interfaces
{
    public interface IRaceRepository
    {
        Race Get(int id);
        List<Race> GetAll();
        Race Add(Race ul);
        Race Update(Race ul);
        bool Delete(int id);
    }
}
