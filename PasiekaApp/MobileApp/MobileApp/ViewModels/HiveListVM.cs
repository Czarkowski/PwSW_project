using MobileApp.ViewModels.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class HiveListVM : HaveSelectionVM<HiveListItemVM>
    {
        public List<HiveListItemVM> _hiveListItemVMs;
        public List<HiveListItemVM> HiveListItemVMs
        {
            get => _hiveListItemVMs;
            set => SetProperty(ref _hiveListItemVMs, value);
        }
    }
}
