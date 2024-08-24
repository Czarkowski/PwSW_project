using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Models
{
    public class Hive : BaseModel
    {
        public Hive()
        {
        }
        public int Number { get; set; }
        public virtual BeeQueen? BeeQueen { get; set; }
        public int? BeeQueenId { get; set; }
        public virtual List<DescriptionHiveReview> DescriptionHiveReviews { get; set; } = new List<DescriptionHiveReview>();
        public DateTime? AddBeeQueenDate { get; set; }
        public string? Description { get; set; }

        public bool IsNucleus { get; set; }
    }
}
