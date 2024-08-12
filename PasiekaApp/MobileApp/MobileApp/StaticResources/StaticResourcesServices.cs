using Data.Core.Services.Interfaces;
using MobileApp.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.StaticResources
{
    public class StaticResourcesServices : IStaticResourcesServices
    {
        private readonly IBeeService _beeService;
        private readonly IPickerItemFactories _pickerItemFactories;
        public StaticResourcesServices(IBeeService beeService, IPickerItemFactories pickerItemFactories)
        {
            _beeService = beeService;
            _pickerItemFactories = pickerItemFactories;
        }

        public async Task InitializeResourcesAsync(ResourceDictionary resourceDictionary)
        {
            var newResourceDictionary = new ResourceDictionary();
            var raceOptions = new Lazy<object>(() =>
            {
                var races = _beeService.GetAllRaces();
                return _pickerItemFactories.CreateRacePickerItems(races);

            });
            newResourceDictionary.Add(StaticResourceKeys.AvailableRaces, raceOptions.Value);
            newResourceDictionary.Add(StaticResourceKeys.Test, "TEST");

            resourceDictionary.MergedDictionaries.Add(newResourceDictionary);
        }

    }
}
