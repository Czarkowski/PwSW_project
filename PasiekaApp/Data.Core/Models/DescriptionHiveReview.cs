using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Models
{
    public class DescriptionHiveReview : BaseModel
    {
        public DescriptionHiveReview()
        {
        }
        public virtual Hive Hive { get; set; }
        public int HiveId { get; set; }
        public virtual Review Review { get; set; }
        public int ReviewId { get; set; }
        public virtual Description Description { get; set; }
        public int? DescriptionId { get; set; }
    }
}
