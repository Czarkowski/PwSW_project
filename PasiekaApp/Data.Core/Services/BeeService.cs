using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Core.Models;
using Data.Core.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Data.Core.Services
{
    public class BeeService : IBeeService
    {
        private readonly BeeDbContext _db;

        public BeeService()
        {
            _db = new BeeDbContext();
            _db.Database.EnsureCreated(); // Upewnij się, że baza danych i tabele są utworzone
        }

        public List<Ul> GetAllUls()
        {
            return _db.Uls.ToList();
        }

        public Rasa GetRaceByBeeQueenId(int id)
        {
            return _db.MatkaPszczelas.Include(x => x.Rasa).FirstOrDefault(x => x.Id == id).Rasa;
        }
    }
}
