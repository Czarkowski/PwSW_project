using MobileApp.ViewModels.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class ApiaryDataReviewsMainVM : BaseVM
    {
        private ReviewTypeListVM _reviewTypeListVM;
        public ReviewTypeListVM ReviewTypeListVM
        {
            get => _reviewTypeListVM;
            set => SetProperty(ref _reviewTypeListVM, value);
        }

        private AddReviewTypeVM _addReviewTypeVM;
        public AddReviewTypeVM AddReviewTypeVM
        {
            get => _addReviewTypeVM;
            set => SetProperty(ref _addReviewTypeVM, value);
        }
    }
}
