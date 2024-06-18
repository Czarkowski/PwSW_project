using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Models
{
    public class OpisUlPrzeglad
    {
        public OpisUlPrzeglad()
        {
        }
        public int Id { get; private set; }
        public Ul Ul { get; set; }
        public int UlId { get; set; }
        public Przeglad Przeglad { get; set; }
        public int PrzegladId { get; set; }
        public Opis Opis { get; set; }
        public int? OpisId { get; set; }
    }
}
