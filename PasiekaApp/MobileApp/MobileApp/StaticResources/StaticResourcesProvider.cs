using Data.Core.Services.Interfaces;
using MobileApp.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.StaticResources
{
    public class StaticResourcesProvider : IStaticResourcesProvider
    {
        private readonly IBeeService _beeService;
        private readonly IPickerItemFactories _pickerItemFactories;
        public StaticResourcesProvider(IBeeService beeService, IPickerItemFactories pickerItemFactories)
        {
            _beeService = beeService;
            _pickerItemFactories = pickerItemFactories;
        }

        public async Task InitializeResourcesAsync(ResourceDictionary resourceDictionary)
        {
            var raceOptions = new Lazy<object>(() =>
            {
                var races = _beeService.GetAllRaces();
                return races;
                //return _pickerItemFactories.CreateRacePickerItems(races);

            });
            resourceDictionary.Add(StaticResourceKeys.AvailableRaces, raceOptions.Value);
            resourceDictionary.Add(StaticResourceKeys.Test, "TEST");

        }

    }
}
