using Microsoft.EntityFrameworkCore;
using PasiekaMainProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasiekaMainProject.Repositories
{
    public class MyDbContext : DbContext
    {
        private static readonly string ConnectionString = "server=localhost;uid=root;database=PasiekaSchema;password=zaq12wsx;port=3306";
        private static MyDbContext instance;
        public static MyDbContext Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MyDbContext();
                }
                return instance;
            }
        }

        //protected MyDbContext(DbContextOptions<MyDbContext> contextOptions) : base(contextOptions)
        //{
        //}

        public DbSet<UlModel> Ul { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(ConnectionString);
        }
    }
}
