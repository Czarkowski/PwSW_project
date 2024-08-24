﻿using Data.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class HiveDetailsVM
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }
        public BeeQueen BeeQueen { get; set; }
        public DateTime? QueenAddDate { get; set; }
        public TimeSpan? QueenAge { get; set; }
        public string QueenDescription { get; set; }
        
    }
}
