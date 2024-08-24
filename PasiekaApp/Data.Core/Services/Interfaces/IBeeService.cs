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
        List<Hive> GetAllHive();
        Hive GetHiveById(int id);
        Hive UpdateHive(Hive ul);
        Race GetRaceByBeeQueenId(int id);
        BeeQueen GetQueenById(int matkaPszczelaId);
        List<BeeQueen> GetAllQueens();
        List<Race> GetAllRaces();
        BeeQueen AddNewQueen(BeeQueen matkaPszczela);
        BeeQueen UpdateQueen(BeeQueen matkaPszczela);
        bool DeleteQueen(BeeQueen matkaPszczela);
        List<Hive> GetAllHiveWithoutQueens();
        List<BeeQueen> GetAllQueensWithoutHive();
    }
}
