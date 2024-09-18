using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Core.Models;
using MobileApp.ViewModels.PickerItems.Base;
using MobileApp.ViewModels.PickerItems.Interfaces;

namespace MobileApp.ViewModels.PickerItems
{
    public class RacePickerItem : PickerItemVM<Race>
    {
        public RacePickerItem(Race value, string name) : base(value, name)
        {
        }
    }
}
