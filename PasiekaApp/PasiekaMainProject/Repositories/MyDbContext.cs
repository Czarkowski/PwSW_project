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
        private static MyDbContext? instance = null;
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

        private MyDbContext() { }
        //protected MyDbContext(DbContextOptions<MyDbContext> contextOptions) : base(contextOptions)
        //{
        //}

        public DbSet<UlModel> Ul { get; set; }
        public DbSet<OpisUlPrzegladModel> OpisUlPrzeglad { get; set; }
        public DbSet<PrzegladModel> Przeglad { get; set; }
        public DbSet<RasaModel> Rasa { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(ConnectionString);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UlModel>(ul =>
            {
                ul.ToTable("Ul");
                ul.HasOne(u => u.Rasa).WithMany(r => r.Uls).HasForeignKey(u => u.RasaId);
            });
                
        }
    }
}
