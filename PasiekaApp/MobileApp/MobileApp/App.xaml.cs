using Data.Core.Services.Interfaces;
using Microsoft.Maui.Hosting;
using MobileApp.Factories.Interfaces;
using MobileApp.StaticResources;

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
