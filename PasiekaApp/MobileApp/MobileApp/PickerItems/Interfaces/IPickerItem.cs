using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.PickerItems.Interfaces
{
    public interface IPickerItem
    {
        int Id { get; set; }
        object Value { get; set; }
        string Name { get; set; }

    }
}
