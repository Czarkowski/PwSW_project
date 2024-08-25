using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels.PickerItems.Interfaces
{
    public interface IPickerItem
    {
        object Value { get; set; }
        string Name { get; set; }
    }
}
