using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasiekaMainProject.Model
{
    public class OpisUlPrzegladModel
    {
        public int Id { get; private set; }
        public DateTime DataDPrzegladu { get; set; }
        public string Opis { get; set; } = string.Empty;
        public int UlId { get; set; }
        public UlModel Ul { get; set; } = new UlModel();
        public int PrzegladId { get; set; }
        public PrzegladModel Przeglad { get; set; } = new PrzegladModel();
    }
}
