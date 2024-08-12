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

        List<Ul> GetAllUls();

        Ul GetUlById(int id);

        Rasa GetRaceByBeeQueenId(int id);
        MatkaPszczela GetQueenById(int matkaPszczelaId);

        List<MatkaPszczela> GetAllQueens();

        List<Rasa> GetAllRaces();
    }
}
