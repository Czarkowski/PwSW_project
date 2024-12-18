﻿using Data.Core;
using Data.Core.Services;
using Data.Core.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using Microsoft.Maui.Hosting;
using MobileApp.Factories.Interfaces;
using MobileApp.Helpers.Interfaces;
using MobileApp.Localizations;
using MobileApp.UserPreferences;
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
        public readonly IServiceScopeFactory ServiceScopeFactory;
        private readonly IInitializeResources _staticResourcesServices;
        private readonly IBeeService _beeService;
        private IServiceScope _currentScope;
        public App(IInitializeResources staticResourcesServices, IServiceProvider serviceProvider, IBeeService beeService, 
            IServiceScopeFactory serviceScopeFactory)
        {
            _beeService = beeService;
            _staticResourcesServices = staticResourcesServices;
            ServicesProvider = serviceProvider;
            ServiceScopeFactory = serviceScopeFactory;

            InitializeComponent();

            InitializeData();

            InitializeMainPage();

        }

        public void ResetScope()
        {
            //ServicesProvider.GetService<BeeDbContext>();
            //if (_currentScope != null)
            //{
            //    _currentScope.Dispose();
            //    _currentScope = null;
            //}
            //_currentScope = ServiceScopeFactory.CreateScope();

            //ServicesProvider.GetService<BeeDbContext>();
            //_currentScope.Dispose();
            //ServicesProvider.GetService<BeeDbContext>();
            //_currentScope = ServicesProvider.CreateScope();
            //using (var scope = ServicesProvider.CreateScope())
            //{
            //    scope.ServiceProvider.GetService<BeeDbContext>();
            //    ServicesProvider.GetService<BeeDbContext>();
            //}
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
            if (!Resources.MergedDictionaries.Contains(_staticResourcesServices.ResourceDictionary))
            {
                Resources.MergedDictionaries.Add(_staticResourcesServices.ResourceDictionary);
            }
            _staticResourcesServices.InitializeResources();
        }
    }
}
