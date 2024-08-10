using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Models
{
    public class MatkaPszczela
    {
        public MatkaPszczela()
        {
        }

        public int Id { get; private set; }
        public Rasa Rasa { get; set; }
        public int RasaId { get; set; }
        public Ul Ul { get; set; }

        public string? Opis { get; set; }
        public DateTime DataUrodzenia { get; set; }
    }
}
