using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<BeeDbContext>
    {
        public BeeDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BeeDbContext>();
            var dbPath = @"E:\BeeApp\BeeApp.db";
            optionsBuilder.UseSqlite($"Data Source={dbPath}");

            return new BeeDbContext(optionsBuilder.Options);
        }
    }
}
