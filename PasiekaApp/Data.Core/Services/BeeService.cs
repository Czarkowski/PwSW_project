using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Core.Models;
using Data.Core.Repositories.Interfaces;
using Data.Core.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Data.Core.Services
{
    public class BeeService : IBeeService
    {
        //private readonly BeeDbContext _db;

        private readonly IUlRepository _ulRepository;
        private readonly IMatkaPszczelaRepository _matkaPszczelaRepository;
        private readonly IRasaRepository _rasaRepository;

        public BeeService(IUlRepository ulRepository, IRasaRepository rasaRepository, IMatkaPszczelaRepository matkaPszczelaRepository)
        {
            _ulRepository = ulRepository;
            _matkaPszczelaRepository = matkaPszczelaRepository;
            _rasaRepository = rasaRepository;
            //_db = new BeeDbContext();
            //_db.Database.EnsureCreated(); // Upewnij się, że baza danych i tabele są utworzone
        }

        public BeeQueen AddNewQueen(BeeQueen matkaPszczela)
        {
            _matkaPszczelaRepository.Add(matkaPszczela);

            return matkaPszczela;
        }

        public bool DeleteQueen(BeeQueen matkaPszczela)
        {
            return _matkaPszczelaRepository.Delete(matkaPszczela);
        }

        public List<BeeQueen> GetAllQueens()
        {
            return _matkaPszczelaRepository.GetAll();
        }

        public List<Race> GetAllRaces()
        {
            return _rasaRepository.GetAll();
        }

        public List<Hive> GetAllHive()
        {
            return _ulRepository.GetAll();
        }

        public List<Hive> GetAllHiveWithoutQueens()
        {
            return _ulRepository.GetAll().Where(x => x.BeeQueen == null).ToList();
        }

        public BeeQueen GetQueenById(int matkaPszczelaId)
        {
            return _matkaPszczelaRepository.Get(matkaPszczelaId);
        }

        public Race GetRaceByBeeQueenId(int id)
        {
            return _matkaPszczelaRepository.Get(id, true)?.Race;
        }

        public Hive GetHiveById(int id)
        {
            return _ulRepository.Get(id);
        }

        public BeeQueen UpdateQueen(BeeQueen matkaPszczela)
        {
            return _matkaPszczelaRepository.Update(matkaPszczela);
        }

        public Hive UpdateHive(Hive ul)
        {
            return _ulRepository.Update(ul);
        }

        public List<BeeQueen> GetAllQueensWithoutHive()
        {
            return _matkaPszczelaRepository.GetAll().Where(x => x.Hive == null).ToList();
        }
    }
}
