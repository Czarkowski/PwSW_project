using MobileApp.ViewModels.PickerItems.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels.Interfaces
{
    public interface IPickerItemListVM<T> where T : class, ISelectableVM
    {
    }
}
