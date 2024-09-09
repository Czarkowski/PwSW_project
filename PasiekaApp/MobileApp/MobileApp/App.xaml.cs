using Data.Core;
using Data.Core.Services;
using Data.Core.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using Microsoft.Maui.Hosting;
using MobileApp.Factories.Interfaces;
using MobileApp.Helpers.Interfaces;
using MobileApp.Localizations;
using MobileApp.MyPreferences;
using MobileApp.Pages;
using System.Globalization;
using System.Resources;
using static System.Formats.Asn1.AsnWriter;

namespace MobileApp
{
    public partial class App : Application
    {
        public static new App Current => (App)Application.Current;
        public readonly IServiceProvider ServicesProvider;
        private readonly IStaticResourcesHelper _staticResourcesServices;
        private readonly IBeeService _beeService;
        private IServiceScope _currentScope;
        public App(IStaticResourcesHelper staticResourcesServices, IServiceProvider serviceProvider, IBeeService beeService)
        {
            _beeService = beeService;
            _staticResourcesServices = staticResourcesServices;
            ServicesProvider = serviceProvider;


            InitializeComponent();

            InitializeData();

            InitializeMainPage();

        }

        public void ResetScope()
        {
            if (_currentScope != null)
            {
                _currentScope.Dispose();
                _currentScope = null;
            }
            _currentScope = ServicesProvider.CreateScope();
        }

        public void InitializeData()
        {
            ResetScope();
            EnsureDbInitialized();
            InitializeStaticResources();
            InitializeLocalizer();
        }

        public void InitializeMainPage()
        {
            InitializeCulture();

            if (MainPage is Shell shell)
            {
                shell.Items.Clear();
            }
            MainPage = new AppShell();
        }

        private void InitializeCulture()
        {
            var languageCode = AppPreferences.Language;
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(languageCode);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(languageCode);
            LocalizeManager.SetCulture(Thread.CurrentThread.CurrentUICulture);
        }

        private void EnsureDbInitialized()
        {
            BeeDbContext.EnsureInitialized();
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
