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
    public class PickerItemListVM<T> : ItemListVM<IPickerItemVM<T>>, IPickerItemListVM<T>
    {
        public T SelectedValue { 
            get => SelectedItem != null ? SelectedItem.Value : default; 
            set => SelectedItem = ItemList.FirstOrDefault(x => x.Value.Equals(value)); 
        }
    }
}
