﻿using Data.Core.Models;
using Data.Core.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Repositories
{
    public class ProductionTypeRepostory : BaseRepository<ProductionType>, IProductionTypeRepostory
    {
        public ProductionTypeRepostory(BeeDbContext beeDbContext) : base(beeDbContext, beeDbContext.ProductionTypes)
        {
        }
    }
}
