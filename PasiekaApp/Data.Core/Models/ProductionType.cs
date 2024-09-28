using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Models
{
    public class ProductionType : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsVisible { get; set; } = true;
        public virtual List<ProductionType> ProductionTypes { get; set; }
    }
}
