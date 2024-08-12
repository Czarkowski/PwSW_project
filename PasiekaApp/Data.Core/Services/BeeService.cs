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

        public MatkaPszczela GetQueenById(int matkaPszczelaId)
        {
            return _matkaPszczelaRepository.Get(matkaPszczelaId);
        }

        public Rasa GetRaceByBeeQueenId(int id)
        {
            return _matkaPszczelaRepository.Get(id, true)?.Rasa;
        }

        public Ul GetUlById(int id)
        {
            return _ulRepository.Get(id);
        }
    }
}
