using Data.Core.Models;
using MobileApp.ApiaryTools;
using MobileApp.Core.Classes;
using MobileApp.Factories.Interfaces;
using MobileApp.Localizations;
using MobileApp.ViewModels.BaseViewModel;
using MobileApp.ViewModels.PickerItems;
using MobileApp.ViewModels.PickerItems.Base;
using MobileApp.ViewModels.PickerItems.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileApp.Utilities.StaticExtensions;

namespace MobileApp.Factories
{
    public class PickerItemFactory : IPickerItemFactories
    {
        public PickerItemListVM<T> CreatePickerItemListVM<T>(List<IPickerItemVM<T>> pickerItemVMs, T defaultSelected = default)
        {
            return new PickerItemListVM<T>()
            {
                ItemList = pickerItemVMs,
                SelectedValue = defaultSelected
            };
        }

        public PickerItemListVM<T> CreatePickerItemListVMFromEnum<T>() where T : Enum
        {
            if (typeof(T) is Type enumType && enumType.IsEnum)
            {
                List<T> enumList = enumType.GetEnumValues().OfType<T>().ToList();
                return CreatePickerItemListVM<T>(enumList.Select(e => 
                    new PickerItemVM<T>(e, LocalizeManager.Translate(EnumExtensions.GetDescription(e))))
                    .OfType<IPickerItemVM<T>>().ToList());
            }
            return null;
        }

        public PickerItemVM<T> CreatePickerItemVM<T>(T value, string name) where T : class
        {
            return new PickerItemVM<T>(value, name);
        }

        public List<RacePickerItem> CreateRacePickerItems(IEnumerable<Race> races)
        {
            return races.Select(r => new RacePickerItem(r, r.Name)).ToList();
        }
    }
}
