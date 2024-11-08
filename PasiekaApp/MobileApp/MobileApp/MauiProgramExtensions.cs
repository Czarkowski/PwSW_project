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
using Plugin.LocalNotification;
using System.Net.Sockets;

namespace MobileApp
{
    public static class MauiProgramExtensions
    {
        public static MauiAppBuilder UseSharedMauiApp(this MauiAppBuilder builder)
        {
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseLocalNotification()
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
            builder.Services.AddTransient<IHiveRepository, HiveRepository>();
            builder.Services.AddTransient<IBeeQueenRepository, BeeQueenRepository>();
            builder.Services.AddTransient<IRaceRepository, RaceRepostory>();
            builder.Services.AddTransient<IReviewTypeRepository, ReviewTypeRepository>();
            builder.Services.AddTransient<IReviewRepository, ReviewRepository>();
            builder.Services.AddTransient<IStockAvailabilityRepository, StockAvailabilityRepository>();
            builder.Services.AddTransient<IDescriptionRepository, DescriptionRepository>();
            builder.Services.AddTransient<IProductionRepository, ProductionRepository>();
            builder.Services.AddTransient<IProductionHiveRepository, ProductionHiveRepository>();
            builder.Services.AddTransient<IProductionTypeRepostory, ProductionTypeRepostory>();
            builder.Services.AddTransient<INotificationRepository, NotificationRepository>();
            return builder;
        }

        private static MauiAppBuilder RegisterServices(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<IBeeService, BeeService>();
            return builder;
        }

        private static MauiAppBuilder RegisterHelpers(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<IInitializeResources, StaticResourcesHelper>();
            builder.Services.AddSingleton<IUpdateDataHelper, UpdateDataHelper>();
            builder.Services.AddSingleton<IFilterDataHelper, FilterDataHelper>();
            builder.Services.AddSingleton<IReviewHelper, ReviewHelper>();
            builder.Services.AddSingleton<IFilterPredicateHelper, FilterPredicateHelper>();
            builder.Services.AddSingleton<IDisplayPromptHelper, DisplayPromptHelper>();
            builder.Services.AddSingleton<IApiaryToolHelper, ApiaryToolHelper>();
            builder.Services.AddSingleton<IPhotoHelper, PhotoHelper>();
            builder.Services.AddTransient<INotificationHelper, NotificationHelper>();
            return builder;
        }

        private static MauiAppBuilder RegisterFactories(this MauiAppBuilder builder)
        {
            builder.Services.AddTransient<IViewModelsFactory, ViewModelsFactory>();
            builder.Services.AddTransient<IPickerItemFactory, PickerItemFactory>();
            builder.Services.AddTransient<IDataToSaveFactory, DataToSaveFactory>();
            return builder;
        }

        private static MauiAppBuilder RegisterPages(this MauiAppBuilder builder)
        {
            builder.Services.AddTransient<HiveListMainPage>();
            builder.Services.AddTransient<QueenListMainPage>();
            builder.Services.AddTransient<ReviewListMainPage>();
            builder.Services.AddTransient<WarehouseMainPage>();
            builder.Services.AddTransient<MainPage>();

            builder.Services.AddTransient<AddQueenPage>();
            builder.Services.AddTransient<EditQueenPage>();
            builder.Services.AddTransient<ChangeQueenPopup>();
            builder.Services.AddTransient<ReviewCreatorMainPage>();
            builder.Services.AddTransient<ReviewDetailsMainPage>();
            builder.Services.AddTransient<ReviewHiveHistoryMainPage>();
            builder.Services.AddTransient<AddRaceMainPage>();
            builder.Services.AddTransient<ApiaryDataRacesMainPage>();
            builder.Services.AddTransient<ApiaryDataReviewsMainPage>();
            builder.Services.AddTransient<ApiaryDataProdutionsMainPage>();
            builder.Services.AddTransient<ApiaryToolSyrupCalculatorMainPage>();
            builder.Services.AddTransient<ApiaryProductionCreatorMainPage>();
            builder.Services.AddTransient<ApiaryProductionSummaryMainPage>();
            return builder;
        }
    }
}
