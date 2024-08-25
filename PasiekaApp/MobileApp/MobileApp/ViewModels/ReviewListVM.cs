using MobileApp.ViewModels.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class ReviewListVM : BaseVM
    {
        private ReviewListFilterVM _reviewListFilterVM;
        public ReviewListFilterVM ReviewListFilterVM
        {
            get => _reviewListFilterVM;
            set => SetProperty(ref _reviewListFilterVM, value);
        }
        private List<ReviewListItemVM> _reviewVMs;
        public List<ReviewListItemVM> ReviewVMs
        {
            get => _reviewVMs;
            set => SetProperty(ref _reviewVMs, value);
        }
    }
}
