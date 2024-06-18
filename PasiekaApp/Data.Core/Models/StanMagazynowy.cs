using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Models
{
    public class StanMagazynowy
    {
        public StanMagazynowy()
        {
        }
        public int Id { get; private set; }
        public string Nazwa { get; set; }
        public double Ilosc { get; set; }
        public string Jednostka { get; set; }
    }
}
