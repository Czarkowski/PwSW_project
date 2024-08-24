using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Devices;
using Data.Core.Models;
using Utilities.StaticExtensions;

namespace Data.Core
{
    public class BeeDbContext : DbContext
    {
        public DbSet<Hive> Uls { get; set; }
        public DbSet<Review> Przeglads { get; set; }
        public DbSet<DescriptionHiveReview> OpisUlPrzeglads { get; set; }
        public DbSet<Race> Rasas { get; set; }
        public DbSet<BeeQueen> MatkaPszczelas { get; set; }
        public DbSet<Description> Opiss { get; set; }
        public DbSet<StanMagazynowy> StanMagazynowys { get; set; }
        public DbSet<ReviewType> ReviewTypes { get; set; }

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
                optionsBuilder
                    .UseLazyLoadingProxies()
                    .UseSqlite($"Data Source={dbPath}");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hive>(ul =>
            {
                ul.ToTable("Ul");
                ul.HasOne(u => u.BeeQueen).WithOne(m => m.Hive).HasForeignKey<Hive>(u => u.BeeQueenId).IsRequired(false).OnDelete(DeleteBehavior.SetNull); ;
            });
            modelBuilder.Entity<BeeQueen>(mp =>
            {
                mp.ToTable("MatkaPszczela");
                mp.HasOne(m => m.Race).WithMany(r => r.MatkaPszczelas).HasForeignKey(m => m.RaceId);
                mp.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<DescriptionHiveReview>(oul =>
            {
                oul.ToTable("OpisUlPrzeglad");
                //oul.HasKey(up => new { up.UlId, up.PrzegladId });
                oul.HasKey(up => up.Id);
                oul.HasOne(up => up.Ul).WithMany(u => u.DescriptionHiveReviews).HasForeignKey(up => up.UlId);
                oul.HasOne(up => up.Przeglad).WithMany(p => p.DescriptionHiveReviews).HasForeignKey(up => up.PrzegladId);
                oul.HasOne(op => op.Opis).WithOne(up => up.DescriptionHiveReview).HasForeignKey<DescriptionHiveReview>(up => up.OpisId).IsRequired(false);
            });

            modelBuilder.Entity<Review>(p =>
            {
                p.ToTable(nameof(Review));
                p.HasOne(p => p.ReviewType).WithMany(rw => rw.Reviews).HasForeignKey(p => p.ReviewTypeId);
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
