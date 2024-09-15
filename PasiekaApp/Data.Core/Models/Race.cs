using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Models
{
    public class Race : BaseModel
    {
        public Race()
        {
        }
        public virtual List<BeeQueen> BeeQueens { get; set; } = new List<BeeQueen>();
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Licznosc { get; set; }
        public int Produktywnosc { get; set; }
        public int Rojliwosc { get; set; }
        public int Higienicznosc { get; set; }
        public int Lagodnosc { get; set; }
        public bool IsVisible { get; set; } = true;

        public override string ToString()
        {
            return Name;
        }
    }
}
