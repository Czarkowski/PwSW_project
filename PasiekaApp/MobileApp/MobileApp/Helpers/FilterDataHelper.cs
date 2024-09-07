using Data.Core.Models;
using Data.Core.Services.Interfaces;
using MobileApp.Helpers.Interfaces;
using MobileApp.Helpers.StaticResources;
using MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Helpers
{
    public class FilterDataHelper : IFilterDataHelper
    {
        private readonly IBeeService _beeService;
        public FilterDataHelper(IBeeService beeService) 
        {
            _beeService = beeService;
        }

        public List<DescriptionHiveReview> GetFiltratedDescriptionReviewsHistory(Hive hive, ReviewListFilterVM reviewHistoryListFilterVM)
        {
            ReviewType reviewType = reviewHistoryListFilterVM.ReviewType == DefaultDatePickerItems.AllReviewType ? null : reviewHistoryListFilterVM.ReviewType;
            return _beeService.GetFiltratedDescriptionReviewsHistory(hive, reviewType, reviewHistoryListFilterVM.FromDate, reviewHistoryListFilterVM.ToDate, reviewHistoryListFilterVM.Uncompleted);
        }

        public List<Review> GetFiltratedReviews(ReviewListFilterVM reviewListFilterVM)
        {
            ReviewType reviewType = reviewListFilterVM.ReviewType == DefaultDatePickerItems.AllReviewType ? null : reviewListFilterVM.ReviewType;
            return _beeService.GetFiltratedReviews(reviewType, reviewListFilterVM.FromDate, reviewListFilterVM.ToDate, reviewListFilterVM.Uncompleted);
        }
    }
}
