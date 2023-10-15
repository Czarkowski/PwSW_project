using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasiekaMainProject.Model
{
    public class UlModel
    {
        [Column("idUl")]
        public long Id { get; private set; }

        public int Numer { get; set; }
        public DateTime DataDodania { get; set; }
        public DateTime DataOstatniegoPrzegladu { get; set; }
        public int WiekMatki { get; set; }
        public DateTime WiekMatkiData { get; set; }
        public string Rasa { get; set; } = string.Empty;
        public string OpisStanu { get; set; } = string.Empty;
        public bool CzyOdklad { get; set; }
        public bool CzyNowaMatka { get; set; }
        public bool CzyWyrojone { get; set; }
    }
}
