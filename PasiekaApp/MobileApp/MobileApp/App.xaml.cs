using Data.Core.Services.Interfaces;
using Microsoft.Maui.Hosting;
using MobileApp.Factories.Interfaces;
using MobileApp.StaticResources;

namespace MobileApp
{
    public partial class App : Application
    {
        public App(IStaticResourcesServices staticResourcesServices)
        {
            InitializeComponent();
            staticResourcesServices.InitializeResourcesAsync(Resources).Wait();
            AddBaseResources();
            MainPage = new AppShell();
        }

        private void AddBaseResources()
        {
        }
    }
}
