using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Models
{
    public class Rasa
    {
        public Rasa()
        {
        }
        public List<MatkaPszczela> MatkaPszczelas { get; set; } = new List<MatkaPszczela>();
        public int Id { get; private set; }
        public string Nazwa { get; set; } = string.Empty;
        public string? Opis { get; set; } = string.Empty;
        public int Licznosc { get; set; }
        public int Produktywnosc { get; set; }
        public int Rojliwosc { get; set; }
        public int Higienicznosc { get; set; }
        public int Lagodnosc { get; set; }
    }
}
