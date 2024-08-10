using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Models
{
    public class Ul
    {
        public Ul()
        {
        }
        public int Id { get; private set; }
        public int Numer { get; set; }
        public MatkaPszczela? MatkaPszczela { get; set; }
        public int? MatkaPszczelaId { get; set; }
        public List<OpisUlPrzeglad> OpisUlPrzeglads { get; set; } = new List<OpisUlPrzeglad>();
        public DateTime? DataPoddaniaMatki { get; set; }
        public string? Opis { get; set; }

        public bool CzyOdklad { get; set; }
    }
}
