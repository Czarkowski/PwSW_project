using Data.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace BeeAppValidation
{
    [TestClass]
    public class BeeDbContextTests
    {
        private DbContextOptions<BeeDbContext> _options;

        [TestInitialize]
        public void Setup()
        {
            // Konfiguracja w pamięci dla testów
            _options = new DbContextOptionsBuilder<BeeDbContext>()
                .UseInMemoryDatabase(databaseName: "BeeDbTest")
                .Options;

            // Opcjonalne czyszczenie bazy
            using var context = new BeeDbContext(_options);
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }

        [TestMethod]
        public void Hive_CRUD_Operations_Success()
        {
            // Create (Zapis do bazy)
            using (var context = new BeeDbContext(_options))
            {
                var hive = new Data.Core.Models.Hive { Number = 1, Description = "Apiary 1" };
                context.Hives.Add(hive);
                context.SaveChanges();
            }

            // Read (Odczyt z bazy)
            using (var context = new BeeDbContext(_options))
            {
                var hive = context.Hives.FirstOrDefault(u => u.Number == 1);
                Assert.IsNotNull(hive);
                Assert.AreEqual("Apiary 1", hive.Description);
            }

            // Update (Aktualizacja)
            using (var context = new BeeDbContext(_options))
            {
                var hive = context.Hives.AsNoTracking().FirstOrDefault(u => u.Number == 1);
                Assert.IsNotNull(hive);

                hive.Description = "Apiary 2";
                context.Hives.Update(hive);
                context.SaveChanges();
            }

            // Read after update
            using (var context = new BeeDbContext(_options))
            {
                var hive = context.Hives.FirstOrDefault(u => u.Number == 1);
                Assert.IsNotNull(hive);
                Assert.AreEqual("Apiary 2", hive.Description);
            }

            // Delete (Usuwanie)
            using (var context = new BeeDbContext(_options))
            {
                var hive = context.Hives.FirstOrDefault(u => u.Number == 1);
                Assert.IsNotNull(hive);

                context.Hives.Remove(hive);
                context.SaveChanges();
            }

            // Verify deletion
            using (var context = new BeeDbContext(_options))
            {
                var hive = context.Hives.FirstOrDefault(u => u.Number == 1);
                Assert.IsNull(hive);
            }
        }
    }
}
