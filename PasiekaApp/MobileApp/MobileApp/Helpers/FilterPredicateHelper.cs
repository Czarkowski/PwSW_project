using MobileApp.Filters;
using MobileApp.Filters.Interfaces;
using MobileApp.Helpers.Interfaces;
using MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Core.Predicates;
using MobileApp.Helpers.StaticResources;

namespace MobileApp.Helpers
{
    public class FilterPredicateHelper : IFilterPredicateHelper
    {
        public FilterPredicate<ReviewHistoryListItemVM> PrepearFilterForReviewHistoryListItemVM(ReviewListFilterVM reviewListFilterVM)
        {
            var predicate = new FilterPredicate<ReviewHistoryListItemVM>();
            if (reviewListFilterVM == null)
            {
                return predicate;
            }

            if (reviewListFilterVM.FromDate.HasValue)
            {
                predicate.AddPredicate(reviewListFilterVM.FromDate, x => x.PlannedDate, (x, y) => x >= y, ConcatType.And);
            }
            if (reviewListFilterVM.ToDate.HasValue)
            {
                predicate.AddPredicate(reviewListFilterVM.ToDate, x => x.PlannedDate, (x, y) => x <= y, ConcatType.And);
            }
            if (reviewListFilterVM.ReviewType != null && !reviewListFilterVM.ReviewType.Equals(DefaultDatePickerItems.AllReviewType))
            {
                predicate.AddPredicate(reviewListFilterVM.ReviewType.Name, x => x.ReviewTypeName, (x, y) => x.Equals(y), ConcatType.And);
            }
            if (reviewListFilterVM.Uncompleted.HasValue && reviewListFilterVM.Uncompleted.Value)
            {
                predicate.AddPredicate(null, x => x.RealizedDate, (x, y) => x.HasValue, ConcatType.And);
            }
            return predicate;
        }
    }
}
