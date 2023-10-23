using Google.Protobuf.WellKnownTypes;
using PasiekaMainProject.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasiekaMainProject.Model
{
    public class UlModel
    {
        public UlModel()
        {
        }

        public UlModel(int id, UlModel model)
        {
            Id = id;
            Numer = model.Numer;
            DataDodania = model.DataDodania;
            DataOstatniegoPrzegladu = model.DataOstatniegoPrzegladu;
            WiekMatki = model.WiekMatki;
            WiekMatkiData = model.WiekMatkiData;
            RasaNazwa = model.RasaNazwa;
            OpisStanu = model.OpisStanu;
            CzyOdklad = model.CzyOdklad;
            CzyNowaMatka = model.CzyNowaMatka;
            CzyWyrojone = model.CzyWyrojone;
            RasaId = model.RasaId;
            Rasa = model.Rasa;
            RamkiGniazdo = model.RamkiGniazdo;
            RamkiNadStawka = model.RamkiNadStawka;
            OpisZaPlanowane = model.OpisZaPlanowane;
            OpisRamki = model.OpisRamki;
            OpisUlPrzegladModels = model.OpisUlPrzegladModels;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }
        public int Numer { get; set; }
        public DateTime DataDodania { get; set; }
        public DateTime DataOstatniegoPrzegladu { get; set; }
        public int WiekMatki { get; set; }
        public DateTime WiekMatkiData { get; set; }
        public string RasaNazwa { get; set; } = string.Empty;
        public string OpisStanu { get; set; } = string.Empty;
        public bool CzyOdklad { get; set; }
        public bool CzyNowaMatka { get; set; }
        public bool CzyWyrojone { get; set; }
        [ForeignKey("Rasa"), DefaultValue(1)]
        public int RasaId { get; set; } = 1;

        private RasaModel rasa;
        public RasaModel Rasa
        {
            get => rasa;
            set
            {
                rasa = value;
                RasaNazwa = value.Nazwa;
            }
}
public int RamkiGniazdo { get; set; }     
        public int RamkiNadStawka { get; set; }     
        public string OpisZaPlanowane { get; set; } = string.Empty;
        public string OpisRamki { get; set; } = string.Empty;
        public List<OpisUlPrzegladModel> OpisUlPrzegladModels { get; set; } = new List<OpisUlPrzegladModel>();

    }
}
