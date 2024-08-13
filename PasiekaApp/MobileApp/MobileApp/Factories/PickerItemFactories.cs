using Data.Core.Models;
using MobileApp.Factories.Interfaces;
using MobileApp.PickerItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Factories
{
    public class PickerItemFactories : IPickerItemFactories
    {
        public List<RacePickerItem> CreateRacePickerItems(IEnumerable<Rasa> races)
        {
            return races.Select(r => new RacePickerItem()
            {
                Value = r,
                Name = r.Nazwa,
            }).ToList();
        }
    }
}
