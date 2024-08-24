using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Core.Models;

namespace Data.Core.Models
{
    public class BeeQueen : BaseModel
    {
        public BeeQueen()
        {
        }

        public virtual Race Race { get; set; }
        public int RaceId { get; set; }
        public virtual Hive Hive { get; set; }
        public string? Description { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime? DeathDate { get; set; }
    }
}
