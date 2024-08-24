using Data.Core.Services.Interfaces;
using Microsoft.Extensions.Localization;
using Microsoft.Maui.Hosting;
using MobileApp.Factories.Interfaces;
using MobileApp.Localizations;
using MobileApp.Pages;
using MobileApp.StaticResources;
using System.Globalization;
using System.Resources;

namespace MobileApp
{
    public partial class App : Application
    {
        public static new App Current => (App)Application.Current;
        public readonly IServiceProvider Services;
        private readonly IStaticResourcesProvider _staticResourcesServices;
        public App(IStaticResourcesProvider staticResourcesServices, IServiceProvider serviceProvider)
        {
            _staticResourcesServices = staticResourcesServices;
            Services = serviceProvider;
            InitializeComponent();
            InitializeStaticResources();
            InitializeLocalizer();

            MainPage = new AppShell();
        }

        private void InitializeLocalizer()
        {
            ResourceManager resourceManager = new ResourceManager("MobileApp.Resources.Languages.Strings", typeof(App).Assembly);
            LocalizeManager.Initialize(resourceManager);
        }

        private void InitializeStaticResources()
        {
            var newResourceDictionary = new ResourceDictionary();
            _staticResourcesServices.InitializeResourcesAsync(newResourceDictionary).Wait();
            Resources.MergedDictionaries.Add(newResourceDictionary);
        }
    }
}
