using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Devices;
using Data.Core.Models;
using Utilities.StaticExtensions;
using System.Runtime.InteropServices.Marshalling;

namespace Data.Core
{
    public class BeeDbContext : DbContext
    {
        public DbSet<Hive> Hives { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<DescriptionHiveReview> DescriptionHiveReviews { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<BeeQueen> BeeQueens { get; set; }
        public DbSet<Description> Descriptions { get; set; }
        public DbSet<StockAvailability> StockAvailabilities { get; set; }
        public DbSet<ReviewType> ReviewTypes { get; set; }
        public DbSet<Production> Productions { get; set; }
        public DbSet<ProductionHive> ProductionHives { get; set; }
        public DbSet<ProductionType> ProductionTypes { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Photo> Photos { get; set; }
        //public DbSet<PhotoDescription> PhotoDescriptions { get; set; }

        public BeeDbContext()
        {
        }

        public BeeDbContext(DbContextOptions<BeeDbContext> options) : base(options)
        {
        }

        public static void ClearDataBase()
        {
            using(var context = new BeeDbContext())
            {
                foreach (var entity in context.Model.GetEntityTypes())
                {
                    var tableName = entity.GetTableName();
                    context.Database.ExecuteSqlRaw($"DELETE FROM {tableName}");
                }

                context.SaveChanges();
            }
        }

        public static void DeleteDataBase()
        {
            using (var context = new BeeDbContext())
            {
                context.Database.EnsureDeleted();
            }
        }

        public static void EnsureInitialized()
        {
            using (var context = new BeeDbContext())
            {
                context.Database.EnsureCreated();
                try
                {
                    if (context.Database.GetPendingMigrations().Any())
                        context.Database.Migrate();
                }
                catch (Exception e)
                {
                }
            }
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
                ul.ToTable(nameof(Hive));
                ul.HasOne(u => u.BeeQueen).WithOne(m => m.Hive).HasForeignKey<Hive>(u => u.BeeQueenId).IsRequired(false).OnDelete(DeleteBehavior.SetNull); ;
            });
            modelBuilder.Entity<BeeQueen>(mp =>
            {
                mp.ToTable(nameof(BeeQueen));
                mp.HasOne(m => m.Race).WithMany(r => r.BeeQueens).HasForeignKey(m => m.RaceId);
                mp.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<DescriptionHiveReview>(oul =>
            {
                oul.ToTable(nameof(DescriptionHiveReview));
                //oul.HasKey(up => new { up.UlId, up.PrzegladId });
                oul.HasKey(up => up.Id);
                oul.HasOne(up => up.Hive).WithMany(u => u.DescriptionHiveReviews).HasForeignKey(up => up.HiveId);
                oul.HasOne(up => up.Review).WithMany(p => p.DescriptionHiveReviews).HasForeignKey(up => up.ReviewId);
                oul.HasOne(op => op.Description).WithOne(up => up.DescriptionHiveReview).HasForeignKey<DescriptionHiveReview>(up => up.DescriptionId).IsRequired(false);
            });

            modelBuilder.Entity<Review>(p =>
            {
                p.ToTable(nameof(Review));
                p.HasOne(p => p.ReviewType).WithMany(rw => rw.Reviews).HasForeignKey(p => p.ReviewTypeId);
                p.HasMany(p => p.Notifications).WithOne(n => n.Review).HasForeignKey(n => n.ReviewId);
            });

            modelBuilder.Entity<ProductionHive>()
                .HasOne(hp => hp.Hive)
                .WithMany(h => h.ProductionHives)
                .HasForeignKey(hp => hp.HiveId);

            modelBuilder.Entity<ProductionHive>()
                .HasOne(hp => hp.Production)
                .WithMany(p => p.ProductionHives)
                .HasForeignKey(hp => hp.ProductionId);

            modelBuilder.Entity<Photo>()
                .HasOne(p => p.Description)
                .WithMany(d => d.Photos)
                .HasForeignKey(p => p.DescriptionId);

            //modelBuilder.Entity<PhotoDescription>()
            //    .HasOne(pd => pd.Description)
            //    .WithMany(d => d.PhotoDescriptions)
            //    .HasForeignKey(pd => pd.DescriptionId);

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
