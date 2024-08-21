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

        public MatkaPszczela AddNewQueen(MatkaPszczela matkaPszczela)
        {
            _matkaPszczelaRepository.Add(matkaPszczela);

            return matkaPszczela;
        }

        public bool DeleteQueen(MatkaPszczela matkaPszczela)
        {
            return _matkaPszczelaRepository.Delete(matkaPszczela);
        }

        public List<MatkaPszczela> GetAllQueens()
        {
            return _matkaPszczelaRepository.GetAll();
        }

        public List<Rasa> GetAllRaces()
        {
            return _rasaRepository.GetAll();
        }

        public List<Ul> GetAllUls()
        {
            return _ulRepository.GetAll();
        }

        public List<Ul> GetAllHiveWithoutQueens()
        {
            return _ulRepository.GetAll().Where(x => x.MatkaPszczela == null).ToList();
        }

        public MatkaPszczela GetQueenById(int matkaPszczelaId)
        {
            return _matkaPszczelaRepository.Get(matkaPszczelaId);
        }

        public Rasa GetRaceByBeeQueenId(int id)
        {
            return _matkaPszczelaRepository.Get(id, true)?.Rasa;
        }

        public Ul GetHiveById(int id)
        {
            return _ulRepository.Get(id);
        }

        public MatkaPszczela UpdateQueen(MatkaPszczela matkaPszczela)
        {
            return _matkaPszczelaRepository.Update(matkaPszczela);
        }

        public Ul UpdateHive(Ul ul)
        {
            return _ulRepository.Update(ul);
        }

        public List<MatkaPszczela> GetAllQueensWithoutHive()
        {
            return _matkaPszczelaRepository.GetAll().Where(x => x.Ul == null).ToList();
        }
    }
}
