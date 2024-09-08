using Data.Core.Predicates;
using MobileApp.Filters;
using MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Helpers.Interfaces
{
    public interface IFilterPredicateHelper
    {
        FilterPredicate<ReviewHistoryListItemVM> PrepearFilterForReviewHistoryListItemVM(ReviewListFilterVM reviewListFilterVM);
    }
}
