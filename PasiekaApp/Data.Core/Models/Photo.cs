using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Models
{
    public class Photo : BaseModel
    {
        public byte[] ImageData { get; set; }
        public DateTime DateTaken { get; set; }
        public virtual Description Description { get; set; }
        public int DescriptionId { get; set; }
    }
}
