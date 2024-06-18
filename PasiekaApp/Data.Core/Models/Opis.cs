using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Models
{
    public class Opis
    {
        public Opis() { }
        public int Id { get; private set; }
        public OpisUlPrzeglad OpisUlPrzeglad { get; set; }
    }
}
