using MobileApp.ViewModels.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class ReviewHiveHistoryVM : BaseVM
    {
        private DescriptionHiveReviewVM _descriptionHiveReviewVM;
        public DescriptionHiveReviewVM DescriptionHiveReviewVM
        {
            get => _descriptionHiveReviewVM;
            set => SetProperty(ref _descriptionHiveReviewVM, value);
        }

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
