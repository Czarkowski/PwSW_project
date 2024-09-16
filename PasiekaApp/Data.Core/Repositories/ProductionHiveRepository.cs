using Data.Core.Models;
using Data.Core.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Repositories
{
    public class ProductionHiveRepository : BaseRepository<ProductionHive>, IProductionHiveRepository
    {
        public ProductionHiveRepository(BeeDbContext beeDbContext) : base(beeDbContext, beeDbContext.ProductionHives)
        {
        }
    }
}
