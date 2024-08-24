using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Models
{
    public class ReviewType
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public virtual List<Review> Reviews { get; set; }
    }
}
