using MobileApp.ViewModels.Interfaces;
using MobileApp.ViewModels.PickerItems.Base;
using MobileApp.ViewModels.PickerItems.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels.BaseViewModel
{
    public class PickerItemListVM<T> : ItemListVM<IPickerItemVM<T>>, IPickerItemListVM<IPickerItemVM<T>> where T : class
    {
        public T SelectedValue => SelectedItem?.Value;
    }
}
