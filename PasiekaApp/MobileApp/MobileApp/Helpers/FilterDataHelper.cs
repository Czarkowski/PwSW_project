using Data.Core.Models;
using Data.Core.Services.Interfaces;
using MobileApp.Helpers.Interfaces;
using MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public List<Review> GetFiltratedReviews(ReviewListFilterVM reviewListFilterVM)
        {
            return _beeService.GetFiltratedReviews(reviewListFilterVM.ReviewType, reviewListFilterVM.FromDate, reviewListFilterVM.ToDate, reviewListFilterVM.Uncompleted);
        }
    }
}
