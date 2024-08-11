using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class QueenListVM
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Race { get; set; }
        public DateTime BirthDate { get; set; }
        public TimeSpan Age { get; set; }
        public int? HiveNumber { get; set; }
    }
}
