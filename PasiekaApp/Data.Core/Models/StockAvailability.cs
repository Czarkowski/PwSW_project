﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Models
{
    public class StockAvailability : BaseModel
    {
        public StockAvailability()
        {
        }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
    }
}
