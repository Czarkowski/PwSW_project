using Data.Core.Models;
using MobileApp.ApiaryTools;
using MobileApp.Core.Classes;
using MobileApp.ViewModels;
using MobileApp.ViewModels.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Factories.Interfaces
{
    public interface IViewModelsFactory
    {
        HiveDetailsVM CreateHiveDetailsVM(Hive hive);
        QueenDetailsVM CreateQueenDetailsVM(BeeQueen matkaPszczela);
        List<QueenListVM> CreateQueenListVM(List<BeeQueen> matkaPszczelas);
        List<HiveListToCreateReviewVM> CreateHiveListToCreateReviewVM(List<Hive> hives);
        ReviewCreatorVM CreateReviewCreatorVM(
            List<HiveListToCreateReviewVM> hiveListToCreateReviewVMs, List<ReviewType> reviewType);
        ReviewListFilterVM CreateReviewListFilterVM();
        ReviewListVM CreateReviewListVM(List<Review> reviews, ReviewListFilterVM filterVM);
        ReviewListItemVM CreateReviewListItemVM(Review review);
        List<ReviewListItemVM> CreateReviewListItemVMs(List<Review> reviews);
        WarehouseVM CreateWarehouseVM(List<StockAvailability> stockAvailabilities);
        WarehouseItemVM CreateEmptyWarehouseItemVM();
        ReviewDetailsVM CreateReviewDetailsVM(Review review);
        DescriptionHiveReviewVM CreateDescriptionHiveReviewVM(DescriptionHiveReview descriptionHiveReview);
        ReviewHiveHistoryVM CreateReviewHistoryVM(Hive hive);
        HiveListMainVM CreateHiveListMainVM(List<Hive> hives);
        AddQueenVM CreateAddQueenVM(List<Race> races);
        AddRaceMainVM CreateAddRaceMainVM();
        ApiaryDataRacesMainVM CreateApiaryDataRacesMainVM(List<Race> races);
        ApiaryDataReviewsMainVM CreateApiaryDataReviewsMainVM(List<ReviewType> reviewType);
        ApiaryDataProductionsMainVM CreateApiaryDataProductionsMainVM(List<ProductionType> productionType);
        ProductionTypeDetailsVM CreateProductionTypeDetailsVM(ProductionType production);
        ApiaryToolSyrupCalculatorMainVM CreateApiaryToolSyrupCalculatorMainVM(
            PickerItemListVM<SyrupCalculationBaseType> syrupCalculationBaseTypes,
            PickerItemListVM<SyrupCalculationRatioType> syrupCalculationRatioTypes);
    }
}
