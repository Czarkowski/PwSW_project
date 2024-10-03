using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Data.Core.Models;
using Data.Core.Predicates;
using Data.Core.Repositories;
using Data.Core.Repositories.Interfaces;
using Data.Core.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Data.Core.Services
{
    public class BeeService : IBeeService
    {
        //private readonly BeeDbContext _db;

        private readonly IHiveRepository _hiveRepository;
        private readonly IBeeQueenRepository _beeQueenRepository;
        private readonly IRaceRepository _raceRepository;
        private readonly IReviewTypeRepository _reviewTypeRepository;
        private readonly IReviewRepository _reviewRepository;
        private readonly IStockAvailabilityRepository _stockAvailabilityRepository;
        private readonly IDescriptionRepository _descriptionRepository;
        private readonly IProductionTypeRepostory _productionTypeRepostory;
        private readonly IProductionHiveRepository _productionHiveRepository;
        private readonly IProductionRepository _productionRepository;
        private readonly IPhotoRepository _photoRepository;
        private readonly INotificationRepository _notificationRepository;
        private readonly IDescriptionHiveReviewRepository _descriptionHiveReviewRepository;
        private readonly BeeDbContext _db;

        public BeeService(BeeDbContext beeDbContext)
        {
            _descriptionRepository = new DescriptionRepository(beeDbContext);
            _hiveRepository = new HiveRepository(beeDbContext);
            _beeQueenRepository = new BeeQueenRepository(beeDbContext);
            _raceRepository = new RaceRepostory(beeDbContext);
            _reviewTypeRepository = new ReviewTypeRepository(beeDbContext);
            _reviewRepository = new ReviewRepository(beeDbContext);
            _stockAvailabilityRepository = new StockAvailabilityRepository(beeDbContext);
            _productionTypeRepostory = new ProductionTypeRepostory(beeDbContext);
            _productionHiveRepository = new ProductionHiveRepository(beeDbContext);
            _productionRepository = new ProductionRepository(beeDbContext);
            _photoRepository = new PhotoRepository(beeDbContext);
            _notificationRepository = new NotificationRepository(beeDbContext);
            _descriptionHiveReviewRepository = new DescriptionHiveReviewRepository(beeDbContext);
            _db = beeDbContext;
            //_db = new BeeDbContext();
            //_db.Database.EnsureCreated(); // Upewnij się, że baza danych i tabele są utworzone
        }

        //public BeeService(BeeDbContext beeDbContext, IHiveRepository hiveRepository, IRaceRepository rasaRepository,
        //    IBeeQueenRepository matkaPszczelaRepository, IReviewTypeRepository reviewTypeRepository,
        //    IReviewRepository reviewRepository, IStockAvailabilityRepository stockAvailabilityRepository,
        //    IDescriptionRepository descriptionRepository)
        //{
        //    _descriptionRepository = descriptionRepository;
        //    _hiveRepository = hiveRepository;
        //    _beeQueenRepository = matkaPszczelaRepository;
        //    _raceRepository = rasaRepository;
        //    _reviewTypeRepository = reviewTypeRepository;
        //    _reviewRepository = reviewRepository;
        //    _stockAvailabilityRepository = stockAvailabilityRepository;
        //    _db = beeDbContext;
        //    //_db = new BeeDbContext();
        //    //_db.Database.EnsureCreated(); // Upewnij się, że baza danych i tabele są utworzone
        //}

        public BeeQueen AddQueen(BeeQueen matkaPszczela)
        {
            _beeQueenRepository.Add(matkaPszczela);

            return matkaPszczela;
        }

        public bool DeleteQueen(BeeQueen matkaPszczela)
        {
            return _beeQueenRepository.Delete(matkaPszczela);
        }

        public List<BeeQueen> GetAllQueens()
        {
            return _beeQueenRepository.GetAll();
        }

        public List<Race> GetAllRaces(bool isVisible)
        {
            return _raceRepository.GetAll().Where(x => isVisible ? x.IsVisible == true : true).ToList();
        }

        public List<Hive> GetAllHive()
        {
            return _hiveRepository.GetAll();
        }

        public List<Hive> GetAllHiveWithoutQueens()
        {
            return _hiveRepository.GetAll().Where(x => x.BeeQueen == null).ToList();
        }

        public BeeQueen GetQueenById(int matkaPszczelaId)
        {
            return _beeQueenRepository.Get(matkaPszczelaId);
        }

        public Race GetRaceByBeeQueenId(int id)
        {
            return _beeQueenRepository.Get(id, true)?.Race;
        }

        public Hive GetHiveById(int id)
        {
            return _hiveRepository.Get(id);
        }

        public BeeQueen UpdateQueen(BeeQueen matkaPszczela)
        {
            return _beeQueenRepository.Update(matkaPszczela);
        }

        public Hive UpdateHive(Hive ul)
        {
            return _hiveRepository.Update(ul);
        }

        public List<BeeQueen> GetAllQueensWithoutHive()
        {
            return _beeQueenRepository.GetAll().Where(x => x.Hive == null).ToList();
        }

        public List<ReviewType> GetAllReviewType(bool isVisible)
        {
            return _reviewTypeRepository.GetAll().Where(x => isVisible ? x.IsVisible == true : true).ToList(); ;
        }

        public Review AddReview(Review review)
        {
            return _reviewRepository.Add(review);
        }

        public List<Review> GetFiltratedReviews(ReviewType reviewType, DateTime? fromDate, DateTime? toDate, bool? uncompleted)
        {
            SqlPredicate<Review> sqlPredicate = new SqlPredicate<Review>();
            if (reviewType != null)
                sqlPredicate.AddPredicate(reviewType, x => x.ReviewType, (x, y) => x.Equals(y), ConcatType.And);
            if (fromDate.HasValue)
                sqlPredicate.AddPredicate(fromDate, x => x.PlannedDate, (x, y) => x >= y, ConcatType.And);
            if (toDate.HasValue)
                sqlPredicate.AddPredicate(toDate, x => x.PlannedDate, (x, y) => x <= y, ConcatType.And);
            if (uncompleted.HasValue && uncompleted == true)
                sqlPredicate.AddPredicate(uncompleted, x => x.RealizedDate.HasValue, (x, y) => x.Equals(false), ConcatType.And);

            return _reviewRepository.GetAll().Where(sqlPredicate.Predicate).ToList();
        }

        public List<StockAvailability> GetAllStock()
        {
           return _stockAvailabilityRepository.GetAll();
        }

        public bool DeleteStock(StockAvailability stock)
        {
            return _stockAvailabilityRepository.Delete(stock);
        }

        public StockAvailability AddStock(StockAvailability stock)
        {
            return _stockAvailabilityRepository.Add(stock);
        }

        public StockAvailability UpdateStock(StockAvailability stock)
        {
            return _stockAvailabilityRepository.Update(stock);
        }

        public Description UpdateDescription(Description description)
        {
            return _descriptionRepository.Update(description);
        }

        public Description AddDescription(Description description)
        {
            return _descriptionRepository.Add(description);
        }

        public Review UpdateReview(Review review)
        {
            return _reviewRepository.Update(review);
        }

        public Hive AddHive(Hive ul)
        {
            //using (BeeDbContext context = new BeeDbContext())
            //{
            //    context.Hives.Add(ul);
            //    context.SaveChanges();
            //};
            //return ul;
            return _hiveRepository.Add(ul);
        }

        public bool DeleteHive(Hive hive)
        {
            return _hiveRepository.Delete(hive);
        }

        public List<DescriptionHiveReview> GetFiltratedDescriptionHiveReviewsHistory(Hive hive, ReviewType reviewType = null, DateTime? fromDate = null,
            DateTime? toDate = null, bool? uncompleted = null)
        {
            SqlPredicate<DescriptionHiveReview> sqlPredicate = new SqlPredicate<DescriptionHiveReview>();
            if (reviewType != null)
                sqlPredicate.AddPredicate(reviewType, x => x.Review.ReviewType, (x, y) => x.Equals(y), ConcatType.And);
            if (fromDate.HasValue)
                sqlPredicate.AddPredicate(fromDate, x => x.Review.PlannedDate, (x, y) => x >= y, ConcatType.And);
            if (toDate.HasValue)
                sqlPredicate.AddPredicate(toDate, x => x.Review.PlannedDate, (x, y) => x <= y, ConcatType.And);
            if (uncompleted.HasValue && uncompleted == true)
                sqlPredicate.AddPredicate(uncompleted, x => x.Review.RealizedDate.HasValue, (x, y) => x.Equals(false), ConcatType.And);

            return hive.DescriptionHiveReviews.Where(sqlPredicate.Predicate).ToList().FindAll(sqlPredicate.Predicate).ToList();
        }

        public Race AddRace(Race race)
        {
            return _raceRepository.Add(race);
        }

        public Race UpdateRace(Race race)
        {
            return _raceRepository.Update(race);
        }

        public ReviewType UpdateReviewType(ReviewType reviewType)
        {
            return _reviewTypeRepository.Update(reviewType);
        }

        public ReviewType AddReviewType(ReviewType reviewType)
        {
            return _reviewTypeRepository.Add(reviewType);
        }

        public List<ProductionType> GetAllProductionType(bool isVisible)
        {
            return _productionTypeRepostory.GetAll().Where(x => isVisible ? x.IsVisible == true : true).ToList();
        }

        public ProductionType UpdateProductionType(ProductionType productionType)
        {
            return _productionTypeRepostory.Update(productionType);
        }

        public ProductionType AddProductionType(ProductionType productionType)
        {
            return _productionTypeRepostory.Add(productionType);
        }

        public Photo AddPhoto(Photo photo)
        {
            return _photoRepository.Add(photo);
        }

        public DescriptionHiveReview UpdateDescriptionHiveReview(DescriptionHiveReview descriptionHiveReview)
        {
            return _descriptionHiveReviewRepository.Update(descriptionHiveReview);
        }
    }
}
