using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Core.Models;
using MobileApp.PickerItems.Interfaces;

namespace MobileApp.PickerItems
{
    public class RacePickerItem : IPickerItem
    {
        public string Name { get; set; }
        public object Value { get; set; }
        //public Rasa Value { get; set; }
        //object IPickerItem.Value { get => Value; set => Value = value as Rasa; }
    }
}
