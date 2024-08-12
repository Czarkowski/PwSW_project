using Data.Core.Models;
using MobileApp.Factories.Interfaces;
using MobileApp.PickerItems.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Factories
{
    public class PickerItemFactories : IPickerItemFactories
    {
        public IEnumerable<RacePickerItem> CreateRacePickerItems(IEnumerable<Rasa> races)
        {
            return races.Select(r => new RacePickerItem()
            {
                Id = r.Id,
                Name = r.Nazwa,
                Value = r
            }).ToList();
        }
    }
}
