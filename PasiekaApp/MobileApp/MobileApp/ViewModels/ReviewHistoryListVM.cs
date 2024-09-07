using MobileApp.ViewModels.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class ReviewHistoryListVM : HaveSelectionVM<ReviewHistoryListItemVM>
    {

        private List<ReviewHistoryListItemVM> _reviewHistoryListItemVMs;
        public List<ReviewHistoryListItemVM> ReviewHistoryListItemVMs
        {
            get => _reviewHistoryListItemVMs;
            set => SetProperty(ref _reviewHistoryListItemVMs, value);
        }
    }
}
