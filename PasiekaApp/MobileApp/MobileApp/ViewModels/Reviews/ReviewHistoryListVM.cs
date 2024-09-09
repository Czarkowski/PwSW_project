using Data.Core.Predicates;
using MobileApp.Filters;
using MobileApp.ViewModels.BaseViewModel;
using MobileApp.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class ReviewHistoryListVM : HaveSelectionVM<ReviewHistoryListItemVM>, IFiltratedListVM<ReviewHistoryListItemVM>
    {
        private List<ReviewHistoryListItemVM> _reviewHistoryListItemVMs;
        public List<ReviewHistoryListItemVM> ReviewHistoryListItemVMs
        {
            get => _reviewHistoryListItemVMs;
            set
            {
                SetProperty(ref _reviewHistoryListItemVMs, value); 
                FiltratedReviewHistoryListItemVMs = new ObservableCollection<ReviewHistoryListItemVM>(value);
            }
        }

        private ObservableCollection<ReviewHistoryListItemVM> _filtratedReviewHistoryListItemVMs;
        public ObservableCollection<ReviewHistoryListItemVM> FiltratedReviewHistoryListItemVMs
        {
            get => _filtratedReviewHistoryListItemVMs;
            private set => SetProperty(ref _filtratedReviewHistoryListItemVMs, value);
        }

        public void ApplyFilter(FilterPredicate<ReviewHistoryListItemVM> filterPredicate)
        {
            FiltratedReviewHistoryListItemVMs.Clear();
            var filtratedData = ReviewHistoryListItemVMs.Where(filterPredicate.Predicate).ToList();
            filtratedData.ForEach(FiltratedReviewHistoryListItemVMs.Add);
        }
    }
}
