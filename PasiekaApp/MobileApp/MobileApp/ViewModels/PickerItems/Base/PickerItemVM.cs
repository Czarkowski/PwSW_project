using MobileApp.ViewModels.BaseViewModel;
using MobileApp.ViewModels.Interfaces;
using MobileApp.ViewModels.PickerItems.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels.PickerItems.Base
{
    public class PickerItemVM<T> : SelectableVM, IPickerItemVM<T>
    {
        public T Value { get; set; }
        public string Name { get; set; }

        public PickerItemVM(T value, string name)
        {
            Value = value;
            Name = name ?? value.ToString();
        }
    }
}
