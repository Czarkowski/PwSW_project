using MobileApp.ViewModels.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels.Interfaces
{
    public interface IMultiSelectedItemListVM<T> : IItemListVM<T> where T : ISelectableVM
    {
        public ObservableCollection<T> SelectedItems { get; set; }
    }
}
