using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasiekaMainProject.Model
{
    public class PrzegladModel
    {
        public int Id { get; private set; }
        public DateTime DataUtworzenia { get; set; }
        public DateTime DataZaPlanowana { get; set; }
        public DateTime DataZaWykonania { get; set; }
        public string Cel { get; set; } = string.Empty;
        public string Opis { get; set; } = string.Empty;
        public int CelEnum { get; set; }
        public List<OpisUlPrzegladModel> OpisUlPrzegladModels { get; set; } = new List<OpisUlPrzegladModel>();
    }
}
