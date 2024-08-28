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
using Data.Core.Repositories.Interfaces;
using Data.Core.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Data.Core.Services
{
    public class BeeService : IBeeService
    {
        //private readonly BeeDbContext _db;

        private readonly IUlRepository _ulRepository;
        private readonly IMatkaPszczelaRepository _matkaPszczelaRepository;
        private readonly IRasaRepository _rasaRepository;
        private readonly IReviewTypeRepository _reviewTypeRepository;
        private readonly IReviewRepository _reviewRepository;
        private readonly BeeDbContext _db;
        

        public BeeService(BeeDbContext beeDbContext, IUlRepository ulRepository, IRasaRepository rasaRepository,
            IMatkaPszczelaRepository matkaPszczelaRepository, IReviewTypeRepository reviewTypeRepository,
            IReviewRepository reviewRepository)
        {
            _ulRepository = ulRepository;
            _matkaPszczelaRepository = matkaPszczelaRepository;
            _rasaRepository = rasaRepository;
            _reviewTypeRepository = reviewTypeRepository;
            _reviewRepository = reviewRepository;
            _db = beeDbContext;
            //_db = new BeeDbContext();
            //_db.Database.EnsureCreated(); // Upewnij się, że baza danych i tabele są utworzone
        }

        public BeeQueen AddQueen(BeeQueen matkaPszczela)
        {
            _matkaPszczelaRepository.Add(matkaPszczela);

            return matkaPszczela;
        }

        public bool DeleteQueen(BeeQueen matkaPszczela)
        {
            return _matkaPszczelaRepository.Delete(matkaPszczela);
        }

        public List<BeeQueen> GetAllQueens()
        {
            return _matkaPszczelaRepository.GetAll();
        }

        public List<Race> GetAllRaces()
        {
            return _rasaRepository.GetAll();
        }

        public List<Hive> GetAllHive()
        {
            return _ulRepository.GetAll();
        }

        public List<Hive> GetAllHiveWithoutQueens()
        {
            return _ulRepository.GetAll().Where(x => x.BeeQueen == null).ToList();
        }

        public BeeQueen GetQueenById(int matkaPszczelaId)
        {
            return _matkaPszczelaRepository.Get(matkaPszczelaId);
        }

        public Race GetRaceByBeeQueenId(int id)
        {
            return _matkaPszczelaRepository.Get(id, true)?.Race;
        }

        public Hive GetHiveById(int id)
        {
            return _ulRepository.Get(id);
        }

        public BeeQueen UpdateQueen(BeeQueen matkaPszczela)
        {
            return _matkaPszczelaRepository.Update(matkaPszczela);
        }

        public Hive UpdateHive(Hive ul)
        {
            return _ulRepository.Update(ul);
        }

        public List<BeeQueen> GetAllQueensWithoutHive()
        {
            return _matkaPszczelaRepository.GetAll().Where(x => x.Hive == null).ToList();
        }

        public List<ReviewType> GetAllReviewType()
        {
            return _reviewTypeRepository.GetAll();
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

            return  _db.Reviews.Where(sqlPredicate.Predicate).ToList().FindAll(sqlPredicate.Predicate).ToList();
        }
    }
}
