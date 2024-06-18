using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Core.Models;

namespace Data.Core
{
    public class BeeService : IBeeService
    {
        private readonly BeeDbContext _context;

        public BeeService()
        {
            _context = new BeeDbContext();
            _context.Database.EnsureCreated(); // Upewnij się, że baza danych i tabele są utworzone
        }

        public void Get()
        {
            
        }
    }
}
