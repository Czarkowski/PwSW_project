using Data.Core.Models;
using MobileApp.PickerItems.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Factories.Interfaces
{
    public interface IPickerItemFactories
    {
        IEnumerable<RacePickerItem> CreateRacePickerItems(IEnumerable<Rasa> races);
    }
}
