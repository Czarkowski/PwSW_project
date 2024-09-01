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
        Hive UpdateHive(Hive ul);
        Race GetRaceByBeeQueenId(int id);
        BeeQueen GetQueenById(int matkaPszczelaId);
        List<BeeQueen> GetAllQueens();
        List<Race> GetAllRaces();
        BeeQueen AddQueen(BeeQueen matkaPszczela);
        BeeQueen UpdateQueen(BeeQueen matkaPszczela);
        bool DeleteQueen(BeeQueen matkaPszczela);
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
    }
}
