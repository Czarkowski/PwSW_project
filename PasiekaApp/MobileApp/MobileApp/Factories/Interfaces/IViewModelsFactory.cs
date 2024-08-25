using Data.Core.Models;
using MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Factories.Interfaces
{
    public interface IViewModelsFactory
    {
        List<UlListVM> CreateUlListVMs();
        HiveDetailsVM CreateUlDetailsVM(int ulId);
        QueenDetailsVM CreateQueenDetailsVM(BeeQueen matkaPszczela);
        List<QueenListVM> CreateQueenListVM(List<BeeQueen> matkaPszczelas);
        List<HiveListToCreateReviewVM> CreateHiveListToCreateReviewVM(List<Hive> hives);
        ReviewCreatorVM CreateReviewCreatorVM(List<HiveListToCreateReviewVM> hiveListToCreateReviewVMs, List<ReviewType> reviewType);
        ReviewListFilterVM CreateReviewListFilterVM();
        ReviewListVM CreateReviewListVM(List<Review> reviews, ReviewListFilterVM filterVM);
        ReviewListItemVM CreateReviewListItemVM(Review review);
    }
}
