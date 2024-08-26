using Data.Core.Services.Interfaces;
using MobileApp.Converters;
using MobileApp.Factories.Interfaces;
using MobileApp.Helpers.Interfaces;
using MobileApp.Pages.Review.List.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Helpers.StaticResources
{
    public class StaticResourcesHelper : IStaticResourcesHelper
    {
        private readonly IBeeService _beeService;
        private readonly IPickerItemFactories _pickerItemFactories;
        public StaticResourcesHelper(IBeeService beeService, IPickerItemFactories pickerItemFactories)
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
            resourceDictionary.Add(StaticResourceKeys.BeeQueenNameConverter, new BeeQueenNameConverter());
            resourceDictionary.Add(StaticResourceKeys.QueenAgeConverter, new QueenAgeConverter());


            resourceDictionary.Add(StaticResourceKeys.ReviewListDataTemplateCompleted, new ReviewListDataTemplateCompleted());
            resourceDictionary.Add(StaticResourceKeys.ReviewListDataTemplateSoon, new ReviewListDataTemplateSoon());
            resourceDictionary.Add(StaticResourceKeys.ReviewListDataTemplateUncmopleted, new ReviewListDataTemplateUncmopleted());

            resourceDictionary.Add(StaticResourceKeys.ReviewListDataTemplateSelector, new ReviewListDataTemplateSelector());

        }
    }
}
