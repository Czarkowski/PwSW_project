using Data.Core.Predicates;
using MobileApp.Filters;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels.Interfaces
{
    public interface IFiltratedListVM<T> where T : class
    {
        void ApplyFilter(FilterPredicate<T> filterPredicate);
    //    public void ApplyFilter(SqlPredicate<ReviewHistoryListItemVM> sqlPredicate)
    //    {
    //        FiltratedList.Clear();
    //        var filtratedData = ReviewHistoryListItemVMs.Where(sqlPredicate.Predicate).ToList();
    //        filtratedData.ForEach(FiltratedList.Add);
    //    }
    //    public ObservableCollection<T> FiltratedList { get; }
    //    {
    //        get => _filtratedReviewHistoryListItemVMs;
    //        private set => SetProperty(ref _filtratedReviewHistoryListItemVMs, value);
    //    }
    }
}
