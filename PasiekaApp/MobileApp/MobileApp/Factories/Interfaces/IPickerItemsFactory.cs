using Data.Core.Models;
using MobileApp.ViewModels.BaseViewModel;
using MobileApp.ViewModels.PickerItems;
using MobileApp.ViewModels.PickerItems.Base;
using MobileApp.ViewModels.PickerItems.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Factories.Interfaces
{
    public interface IPickerItemFactories
    {
        List<RacePickerItem> CreateRacePickerItems(IEnumerable<Race> races);
        PickerItemListVM<T> CreatePickerItemListVM<T>(List<IPickerItemVM<T>> pickerItemVMs, T defaultSelected = default);
        PickerItemListVM<T> CreatePickerItemListVMFromEnum<T>() where T : Enum;
        PickerItemVM<T> CreatePickerItemVM<T>(T value, string name) where T : class;
    }
}
