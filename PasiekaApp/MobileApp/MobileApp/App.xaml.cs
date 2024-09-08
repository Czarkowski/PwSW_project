using Data.Core;
using Data.Core.Services;
using Data.Core.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using Microsoft.Maui.Hosting;
using MobileApp.Factories.Interfaces;
using MobileApp.Helpers.Interfaces;
using MobileApp.Localizations;
using MobileApp.Pages;
using System.Globalization;
using System.Resources;

namespace MobileApp
{
    public partial class App : Application
    {
        public static new App Current => (App)Application.Current;
        public readonly IServiceProvider Services;
        private readonly IStaticResourcesHelper _staticResourcesServices;
        private readonly IBeeService _beeService;
        public App(IStaticResourcesHelper staticResourcesServices, IServiceProvider serviceProvider, IBeeService beeService)
        {
            _beeService = beeService;
            _staticResourcesServices = staticResourcesServices;
            Services = serviceProvider;
            EnsureDbInitialized();
            InitializeComponent();

            InitializeMainPage();
        }

        public void InitializeMainPage()
        {
            InitializeStaticResources();
            InitializeCulture();
            InitializeLocalizer();

            MainPage = new AppShell();
        }

        private void InitializeCulture()
        {
            var languageCode = Preferences.Get("AppLanguage", "pl");
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(languageCode);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(languageCode);
        }

        private void EnsureDbInitialized()
        {
            using (var context = new BeeDbContext())
            {
                context.Database.EnsureCreated();
                context.Database.Migrate();
            }
        }

        private void InitializeLocalizer()
        {
            ResourceManager resourceManager = new ResourceManager("MobileApp.Resources.Languages.Strings", typeof(App).Assembly);
            LocalizeManager.Initialize(resourceManager);
            LocalizeManager.SetCulture(Thread.CurrentThread.CurrentUICulture);
        }

        private void InitializeStaticResources()
        {
            var newResourceDictionary = new ResourceDictionary();
            _staticResourcesServices.InitializeResourcesAsync(newResourceDictionary).Wait();
            Resources.MergedDictionaries.Add(newResourceDictionary);
        }
    }
}
