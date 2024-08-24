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
    public class PickerItemFactory : IPickerItemFactories
    {
        public List<RacePickerItem> CreateRacePickerItems(IEnumerable<Race> races)
        {
            return races.Select(r => new RacePickerItem()
            {
                Value = r,
                Name = r.Name,
            }).ToList();
        }
    }
}
