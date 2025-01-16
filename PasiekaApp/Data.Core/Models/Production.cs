using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Models
{
    public class Production : BaseModel
    {
        public Production() { }
        public int ProductionTypeId { get; set; }
        public virtual ProductionType ProductionType { get; set; }
        public virtual List<ProductionHive> ProductionHives { get; set; } = new List<ProductionHive>();
        public decimal Value { get; set; }
        public int Unit { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
