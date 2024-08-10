using Data.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Services.Interfaces
{
    public interface IBeeService
    {

        public List<Ul> GetAllUls();

        public Rasa GetRaceByBeeQueenId(int id);
    }
}
