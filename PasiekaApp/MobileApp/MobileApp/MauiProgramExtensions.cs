using CommunityToolkit.Maui;
using Data.Core;
using Data.Core.Repositories;
using Data.Core.Repositories.Interfaces;
using Data.Core.Services;
using Data.Core.Services.Interfaces;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.Extensions.Logging;
using MobileApp.Factories;
using MobileApp.Factories.Interfaces;
using MobileApp.Helpers;
using MobileApp.Helpers.Interfaces;
using MobileApp.Helpers.StaticResources;
using MobileApp.Pages;
using MobileApp.Pages.HiveList.Views;

namespace MobileApp
{
    public static class MauiProgramExtensions
    {
        public static MauiAppBuilder UseSharedMauiApp(this MauiAppBuilder builder)
        {
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder
                .RegisterRepositories()
                .RegisterFactories()
                .RegisterPages()
                .RegisterHelpers()
                .RegisterServices();
            //builder.Services.AddSingleton<IViewModelsFactories>(provider =>
            //{
            //    IBeeService? beeService = provider.GetService<IBeeService>();
            //    return new ViewModelsFactories(beeService);
            //});
            //builder.Services.AddSingleton<ISqlitePlatformPath>(provider =>
            //{
            //    if (Device.RuntimePlatform == Device.Android)
            //    {
            //        return new SqlitePlatformPath_Android();
            //    }
            //    else
            //    {
            //        // Domyślnie dla innych platform (np. WinUI)
            //        return new SqlitePlatformPath_WinUI();
            //    }
            //});
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder;
        }

        private static MauiAppBuilder RegisterRepositories(this MauiAppBuilder builder)
        {
            builder.Services.AddDbContext<BeeDbContext>();
            builder.Services.AddSingleton<IUlRepository, UlRepository>();
            builder.Services.AddSingleton<IMatkaPszczelaRepository, MatkaPszczelaRepostory>();
            builder.Services.AddSingleton<IRasaRepository, RasaRepostory>();
            builder.Services.AddSingleton<IReviewTypeRepository, ReviewTypeRepository>();
            builder.Services.AddSingleton<IReviewRepository, ReviewRepository>();
            return builder;
        }

        private static MauiAppBuilder RegisterServices(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<IBeeService, BeeService>();
            return builder;
        }

        private static MauiAppBuilder RegisterHelpers(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<IStaticResourcesHelper, StaticResourcesHelper>();
            builder.Services.AddSingleton<IUpdateDataHelper, UpdateDataHelper>();
            builder.Services.AddSingleton<IFilterDataHelper, FilterDataHelper>();
            return builder;
        }

        private static MauiAppBuilder RegisterFactories(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<IViewModelsFactory, ViewModelsFactory>();
            builder.Services.AddSingleton<IPickerItemFactories, PickerItemFactory>();
            builder.Services.AddSingleton<IDataToSaveFactory, DataToSaveFactory>();
            return builder;
        }

        private static MauiAppBuilder RegisterPages(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<HiveListMainPage>();
            builder.Services.AddSingleton<QueenListMainPage>();
            builder.Services.AddSingleton<ReviewListMainPage>();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddTransient<AddQueenPage>();
            builder.Services.AddTransient<EditQueenPage>();
            builder.Services.AddTransient<ChangeQueenPopup>();
            builder.Services.AddTransient<ReviewCreatorMainPage>();
            return builder;
        }
    }
}
