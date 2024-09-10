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
    public class StaticResourcesHelper : IInitializeResources
    {
        private readonly IBeeService _beeService;
        private readonly IPickerItemFactories _pickerItemFactories;
        private ResourceDictionary _resourceDictionary;
        public ResourceDictionary ResourceDictionary
        {
            get => _resourceDictionary;
            private set => _resourceDictionary = value;
        }
        public StaticResourcesHelper(IBeeService beeService, IPickerItemFactories pickerItemFactories)
        {
            _beeService = beeService;
            _pickerItemFactories = pickerItemFactories;
            ResourceDictionary = new ResourceDictionary();
        }

        public void InitializeResources()
        {
            ResourceDictionary.Clear();
            var raceOptions = new Lazy<object>(() =>
            {
                var races = _beeService.GetAllRaces();
                return races;
                //return _pickerItemFactories.CreateRacePickerItems(races);

            });
            ResourceDictionary.Add(StaticResourceKeys.AvailableRaces, raceOptions.Value);
            ResourceDictionary.Add(StaticResourceKeys.BeeQueenNameConverter, new BeeQueenNameConverter());
            ResourceDictionary.Add(StaticResourceKeys.QueenAgeConverter, new QueenAgeConverter());
            ResourceDictionary.Add(StaticResourceKeys.IsSelectedToColorConverter, new IsSelectedToColorConverter());
            ResourceDictionary.Add(StaticResourceKeys.DoubleToStringConverter, new DoubleToStringConverter());
            ResourceDictionary.Add(StaticResourceKeys.NullToBooleanConverter, new NullToBooleanConverter());
            ResourceDictionary.Add(StaticResourceKeys.ReviewListDataTemplateCompleted, new ReviewListDataTemplateCompleted());
            ResourceDictionary.Add(StaticResourceKeys.ReviewListDataTemplateSoon, new ReviewListDataTemplateSoon());
            ResourceDictionary.Add(StaticResourceKeys.ReviewListDataTemplateUncmopleted, new ReviewListDataTemplateUncmopleted());
            ResourceDictionary.Add(StaticResourceKeys.ReviewListDataTemplateSelector, new ReviewListDataTemplateSelector());
            ResourceDictionary.Add(StaticResourceKeys.ReviewHiveHistortListDataTemplateSelector, new ReviewHiveHistortListDataTemplateSelector());
        }
    }
}
