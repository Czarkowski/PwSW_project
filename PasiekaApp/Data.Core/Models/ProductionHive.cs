using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Models
{
    public class ProductionHive : BaseModel
    {
        public ProductionHive() { }
        public int ProductionId { get; set; }
        public int HiveId { get; set; }
        public virtual Hive Hive { get; set; }
        public virtual Production Production { get; set; }
    }
}
