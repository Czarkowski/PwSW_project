using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Models
{
    public class Przeglad
    {
        public Przeglad()
        {
        }
        public int Id { get; private set; }
        public string Description { get; set; }
        public DateTime PlannedDate { get; set; }
        public DateTime? RealizedDate { get; set; }
        public int ReviewTypeId { get; set; }
        public virtual ReviewType ReviewType { get; set; }
        public  virtual List<OpisUlPrzeglad> OpisUlPrzeglads{ get; set; } = new List<OpisUlPrzeglad>();
    }
}
