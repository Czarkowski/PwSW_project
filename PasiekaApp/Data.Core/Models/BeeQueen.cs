using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Models
{
    public class BeeQueen
    {
        public BeeQueen()
        {
        }

        public int Id { get; set; }
        public virtual Race Race { get; set; }
        public int RaceId { get; set; }
        public virtual Hive Hive { get; set; }
        public string? Description { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime? DeathDate { get; set; }
    }
}
