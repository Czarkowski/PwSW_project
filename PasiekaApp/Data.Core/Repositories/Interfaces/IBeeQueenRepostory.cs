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
        BeeQueen Get(int id, bool includeRelations = false);
        List<BeeQueen> GetAll();
        BeeQueen Add(BeeQueen beeQueen);
        BeeQueen Update(BeeQueen beeQueen);
        bool Delete(BeeQueen beeQueen);
    }
}
