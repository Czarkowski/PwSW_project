using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace PasiekaMainProject.Model
{
    public class RasaModel
    {
        public RasaModel()
        {
        }
        private RasaModel(int id)
        {
            this.Id = id;
        }

        public int Id { get; private set; }
        public string Nazwa { get; set; } = string.Empty;
        public string Opis { get; set; } = string.Empty;
        public int Licznosc { get; set; }
        public int Produktywnosc { get; set; }
        public int Rojliwosc { get; set; }
        public int Higienicznosc { get; set; }
        public int Lagodnosc { get; set; }
        public List<UlModel> Uls {  get; set; } = new List<UlModel>();
    }
}
