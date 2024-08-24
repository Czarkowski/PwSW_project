using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Models
{
    public class DescriptionHiveReview
    {
        public DescriptionHiveReview()
        {
        }
        public int Id { get; private set; }
        public virtual Hive Ul { get; set; }
        public int UlId { get; set; }
        public virtual Review Przeglad { get; set; }
        public int PrzegladId { get; set; }
        public virtual Description Opis { get; set; }
        public int? OpisId { get; set; }
    }
}
