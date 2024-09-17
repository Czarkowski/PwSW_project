using Data.Core.Models;
using MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Factories.Interfaces
{
    public interface IDataToSaveFactory
    {
        BeeQueen CreateBeeGueen(QueenDetailsVM queenDetailsVM);
        Description CreateDescription(DescriptionHiveReviewVM descriptionHiveReviewVM);
        Review CreateReview(ReviewCreatorVM queenDetailsVM);
        StockAvailability CreateStockAvailability(WarehouseItemVM warehouseItemVM);
        Hive CreateEmptyHive();
        Race CreateRace(AddRaceMainVM addRaceMainVM);
        ReviewType CreateReviewType(AddReviewTypeVM addReviewTypeVM);
        ProductionType CreateProductionType(ProductionTypeDetailsVM productionTypeDetailsVM);
    }
}
