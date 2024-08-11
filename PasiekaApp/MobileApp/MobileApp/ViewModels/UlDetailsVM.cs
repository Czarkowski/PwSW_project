using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class UlDetailsVM
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }

        public DateTime QueenAddDate { get; set; }
        public TimeSpan? QueenAge { get; set; }
        public string QueenDescription { get; set; }
        
    }
}
