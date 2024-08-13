using Data.Core.Services.Interfaces;
using Microsoft.Maui.Hosting;
using MobileApp.Factories.Interfaces;
using MobileApp.StaticResources;

namespace MobileApp
{
    public partial class App : Application
    {
        private readonly IStaticResourcesServices _staticResourcesServices;
        public App(IStaticResourcesServices staticResourcesServices)
        {
            _staticResourcesServices = staticResourcesServices;

            InitializeComponent();
            InitializeStaticResources();
            MainPage = new AppShell();
        }

        private void InitializeStaticResources()
        {
            var newResourceDictionary = new ResourceDictionary();
            _staticResourcesServices.InitializeResourcesAsync(newResourceDictionary).Wait();
            Resources.MergedDictionaries.Add(newResourceDictionary);
        }
    }
}
