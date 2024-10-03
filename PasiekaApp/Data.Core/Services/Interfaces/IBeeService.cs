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
        bool DeleteHive(Hive hive);
        Race GetRaceByBeeQueenId(int id);
        BeeQueen GetQueenById(int beeQueenId);
        List<BeeQueen> GetAllQueens();
        List<Race> GetAllRaces(bool isVisible = true);
        BeeQueen AddQueen(BeeQueen beeQueen);
        BeeQueen UpdateQueen(BeeQueen beeQueen);
        bool DeleteQueen(BeeQueen beeQueen);
        List<Hive> GetAllHiveWithoutQueens();
        List<BeeQueen> GetAllQueensWithoutHive();
        List<ReviewType> GetAllReviewType(bool isVisible = true);
        Review AddReview(Review review);
        List<Review> GetFiltratedReviews(ReviewType reviewType = default, DateTime? fromDate = default, DateTime? toDate = default, bool? Uncompleted = default);
        bool DeleteStock(StockAvailability stock);
        StockAvailability AddStock(StockAvailability stock);
        StockAvailability UpdateStock(StockAvailability stock);
        Description UpdateDescription(Description description);
        Description AddDescription(Description description);
        DescriptionHiveReview UpdateDescriptionHiveReview(DescriptionHiveReview descriptionHiveReview);
        Review UpdateReview(Review review);
        List<DescriptionHiveReview> GetFiltratedDescriptionHiveReviewsHistory(Hive hive, ReviewType reviewType = default, DateTime? fromDate = default, DateTime? toDate = default, bool? uncompleted = default);
        Race AddRace(Race race);
        Race UpdateRace(Race race);
        ReviewType UpdateReviewType(ReviewType reviewType);
        ReviewType AddReviewType(ReviewType reviewType);
        List<ProductionType> GetAllProductionType(bool isVisible);
        ProductionType UpdateProductionType(ProductionType productionType);
        ProductionType AddProductionType(ProductionType productionType);
        Photo AddPhoto(Photo photo);
    }
}
