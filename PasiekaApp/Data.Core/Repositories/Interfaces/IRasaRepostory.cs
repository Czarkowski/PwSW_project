using Data.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Repositories.Interfaces
{
    public interface IRasaRepository
    {
        Rasa Get(int id);
        List<Rasa> GetAll();
        Rasa Add(Rasa ul);
        Rasa Update(Rasa ul);
        bool Delete(int id);
    }
}
