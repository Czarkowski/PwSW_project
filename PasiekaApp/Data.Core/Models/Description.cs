using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Models
{
    public class Description : BaseModel
    {
        public Description() { }
        public virtual DescriptionHiveReview DescriptionHiveReview { get; set; }
        public string? Text { get; set; }
    }
}
