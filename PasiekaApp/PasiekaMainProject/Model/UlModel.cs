using Google.Protobuf.WellKnownTypes;
using PasiekaMainProject.Annotations;
using PasiekaMainProject.Helpers;
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

        public UlModel(int nr)
        {
            Numer = nr;
        }

        public UlModel(int id, UlModel model)
        {
            Id = id;
            Numer = model.Numer;
            DataDodania = model.DataDodania;
            DataOstatniejModyfikacji = model.DataOstatniejModyfikacji;
            WiekMatki = model.WiekMatki;
            DataPoddaniaMatki = model.DataPoddaniaMatki;
            OpisStanu = model.OpisStanu;
            CzyOdklad = model.CzyOdklad;
            CzyNowaMatka = model.CzyNowaMatka;
            CzyWyrojone = model.CzyWyrojone;
            RasaId = model.RasaId;
            Rasa = model.Rasa;
            RamkiGniazdo = model.RamkiGniazdo;
            RamkiNadStawka = model.RamkiNadStawka;
            OpisZaplanowane = model.OpisZaplanowane;
            OpisRamki = model.OpisRamki;
            OpisUlPrzegladModels = model.OpisUlPrzegladModels;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }
        public int Numer { get; set; }
        public DateTime DataDodania { get; set; }
        [Column("DataOstatniegoPrzegladu")]
        public DateTime DataOstatniejModyfikacji { get; set; }
        [Column("WiekMatki")]
        public int WiekMatki { get; set; }
        [Column("WiekMatkiData")]
        public DateTime DataPoddaniaMatki { get; set; }
        public string RasaNazwa => Rasa?.Nazwa ?? String.Empty;
        public string OpisStanu { get; set; } = string.Empty;
        [DescriptionForForm(ClbIndexesStruct.Odklad)]
        public bool CzyOdklad { get; set; }
        [DescriptionForForm(ClbIndexesStruct.NowaMatka)]
        public bool CzyNowaMatka { get; set; }
        [DescriptionForForm(ClbIndexesStruct.Wyrojone)]
        public bool CzyWyrojone { get; set; }
        //[ForeignKey("RasaId")]
        public int RasaId { get; set; }
        public RasaModel Rasa { get; set; }
        //private RasaModel rasa;
        //public RasaModel Rasa
        //{
        //    get => rasa;
        //    set
        //    {
        //        rasa = value;
        //        RasaNazwa = value.Nazwa;
        //    }
        //}
        public int RamkiGniazdo { get; set; }
        public int RamkiNadStawka { get; set; }
        public string OpisZaplanowane { get; set; } = string.Empty;
        public string OpisRamki { get; set; } = string.Empty;
        public List<OpisUlPrzegladModel> OpisUlPrzegladModels { get; set; } = new List<OpisUlPrzegladModel>();
        //public int PoseId { get; set; }
        public PoseModel Pose { get; set; }

        public DateTime? GetDataOstatniegoPrzegladu()
        {
            List<OpisUlPrzegladModel> oupm;
            if (OpisUlPrzegladModels.IsNullOrEmpty())
            {
                oupm = MyDbContext.Instance.OpisUlPrzeglad.Where(x => x.UlId == this.Id).OrderByDescending(x => x.DataPrzegladu).ToList();
            }
            else
            {
                oupm = OpisUlPrzegladModels.OrderByDescending(x => x.DataPrzegladu).ToList();
            }

            if (oupm.IsNullOrEmpty())
            {
                return null;
            }

            return oupm[0].DataPrzegladu;
        }

        public int GetRelQueenAge()
        {
            return WiekMatki + DateTime.Now.Year - DataDodania.Year;
        }

    }
}
