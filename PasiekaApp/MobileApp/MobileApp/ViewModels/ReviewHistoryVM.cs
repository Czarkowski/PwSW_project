using MobileApp.ViewModels.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class ReviewHistoryVM : BaseVM
    {

        private ReviewListFilterVM reviewHistoryListFilterVM;
        public ReviewListFilterVM ReviewHistoryListFilterVM
        {
            get => reviewHistoryListFilterVM;
            set => SetProperty(ref reviewHistoryListFilterVM, value);
        }

        private ReviewHistoryListVM _reviewHistoryListVM;
        public ReviewHistoryListVM ReviewHistoryListVM
        {
            get => _reviewHistoryListVM;
            set => SetProperty(ref _reviewHistoryListVM, value);
        }
    }
}
