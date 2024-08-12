using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.PickerItems.Interfaces
{
    public class RacePickerItem : IPickerItem
    {
        public int Id { get; set; }
        public object Value { get; set; }
        public string Name { get; set; }

        public static implicit operator string(RacePickerItem item)
        {
            return item.Name = item.Name ?? string.Empty;
        }
    }
}
