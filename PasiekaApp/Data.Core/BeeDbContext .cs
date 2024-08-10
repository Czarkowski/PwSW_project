using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Devices;
using Utilities;
using Data.Core.Models;

namespace Data.Core
{
    public class BeeDbContext : DbContext
    {
        public DbSet<Ul> Uls { get; set; }
        public DbSet<Przeglad> Przeglads { get; set; }
        public DbSet<OpisUlPrzeglad> OpisUlPrzeglads { get; set; }
        public DbSet<Rasa> Rasas { get; set; }
        public DbSet<MatkaPszczela> MatkaPszczelas { get; set; }
        public DbSet<Opis> Opiss { get; set; }
        public DbSet<StanMagazynowy> StanMagazynowys { get; set; }

        public BeeDbContext()
        {
        }

        public BeeDbContext(DbContextOptions<BeeDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var dbPath = GetDataSourceFilePath();
                optionsBuilder.UseSqlite($"Data Source={dbPath}");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ul>(ul =>
            {
                ul.ToTable("Ul");
                ul.HasOne(u => u.MatkaPszczela).WithOne(m => m.Ul).HasForeignKey<Ul>(u => u.MatkaPszczelaId).IsRequired(false).OnDelete(DeleteBehavior.SetNull); ;
            });
            modelBuilder.Entity<MatkaPszczela>(mp =>
            {
                mp.ToTable("MatkaPszczela");
                mp.HasOne(m => m.Rasa).WithMany(r => r.MatkaPszczelas).HasForeignKey(m => m.RasaId);
                mp.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<OpisUlPrzeglad>(oul =>
            {
                oul.ToTable("OpisUlPrzeglad");
                //oul.HasKey(up => new { up.UlId, up.PrzegladId });
                oul.HasKey(up => up.Id);
                oul.HasOne(up => up.Ul).WithMany(u => u.OpisUlPrzeglads).HasForeignKey(up => up.UlId);
                oul.HasOne(up => up.Przeglad).WithMany(p => p.OpisUlPrzeglads).HasForeignKey(up => up.PrzegladId);
                oul.HasOne(op => op.Opis).WithOne(up => up.OpisUlPrzeglad).HasForeignKey<OpisUlPrzeglad>(up => up.OpisId).IsRequired(false);
            });
        }

        internal static string GetDataSourceFilePath()
        {
            var platform = DeviceInfo.Platform;

            var dbFileName = @"BeeApp.db";
            var dbPath = string.Empty;
            var path = AppContext.BaseDirectory;
            if (platform == DevicePlatform.Android)
            {
                dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), dbFileName);
            }
            else if (platform == DevicePlatform.WinUI)
            {
                dbPath = Path.Combine(@"E:\BeeApp\", dbFileName);
            }
            else
            {
                //dbPath = @"E:\BeeApp\BeeApp.db";
                throw new PlatformNotSupportedException("Platform not supported");
            }
            var dbDir = Path.GetDirectoryName(dbPath) ?? string.Empty;

            if (!dbDir.IsNEoWS() && !Directory.Exists(dbDir))
            {
                Directory.CreateDirectory(dbDir);
            }

            return dbPath;
        }
    }
}
