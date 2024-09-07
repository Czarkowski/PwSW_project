using Data.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Services.Interfaces
{
    public interface IBeeService
    {
        List<Hive> GetAllHive();
        List<StockAvailability> GetAllStock();
        Hive GetHiveById(int id);
        Hive UpdateHive(Hive hive);
        Hive AddHive(Hive hive);
        bool DeleteHive(int hiveId);
        Race GetRaceByBeeQueenId(int id);
        BeeQueen GetQueenById(int beeQueenId);
        List<BeeQueen> GetAllQueens();
        List<Race> GetAllRaces();
        BeeQueen AddQueen(BeeQueen beeQueen);
        BeeQueen UpdateQueen(BeeQueen beeQueen);
        bool DeleteQueen(BeeQueen beeQueen);
        List<Hive> GetAllHiveWithoutQueens();
        List<BeeQueen> GetAllQueensWithoutHive();
        List<ReviewType> GetAllReviewType();
        Review AddReview(Review review);
        List<Review> GetFiltratedReviews(ReviewType reviewType = default, DateTime? fromDate = default, DateTime? toDate = default, bool? Uncompleted = default);
        bool DeleteStock(StockAvailability stock);
        StockAvailability AddStock(StockAvailability stock);
        StockAvailability UpdateStock(StockAvailability stock);
        Description UpdateDescription(Description description);
        Description AddDescription(Description description);
        Review UpdateReview(Review review);
        List<DescriptionHiveReview> GetFiltratedDescriptionReviewsHistory(Hive hive, ReviewType reviewType = default, DateTime? fromDate = default, DateTime? toDate = default, bool? uncompleted = default);
    }
}
