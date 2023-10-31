using PasiekaMainProject.MyEnums;
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
        public DateTime? DataPrzegladu { get; set; }
        public string Opis { get; set; } = string.Empty;
        public int UlId { get; set; }
        public UlModel Ul { get; set; }
        public int PrzegladId { get; set; }
        public PrzegladModel Przeglad { get; set; }

        [NotMapped]
        public int Numer => Ul?.Numer ?? default;
        [NotMapped]
        public bool IsCompleted => DataPrzegladu != null;
        [NotMapped]
        public CelEnum? CelEnum => Przeglad?.CelEnum;
        [NotMapped]
        public DateTime? DataZaplanowana => Przeglad?.DataZaplanowana;

    }
}
