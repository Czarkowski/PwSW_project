using Data.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Repositories.Interfaces
{
    public interface IMatkaPszczelaRepository
    {
        MatkaPszczela Get(int id, bool includeRelations = false);
        List<MatkaPszczela> GetAll();
        MatkaPszczela Add(MatkaPszczela ul);
        MatkaPszczela Update(MatkaPszczela ul);
        bool Delete(int id);
    }
}
