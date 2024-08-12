using Data.Core;
using Data.Core.Repositories;
using Data.Core.Repositories.Interfaces;
using Data.Core.Services;
using Data.Core.Services.Interfaces;
using Microsoft.Extensions.Logging;
using MobileApp.Factories;
using MobileApp.Factories.Interfaces;
using MobileApp.Pages;
using MobileApp.StaticResources;

namespace MobileApp
{
    public static class MauiProgramExtensions
    {
        public static MauiAppBuilder UseSharedMauiApp(this MauiAppBuilder builder)
        {
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder
                .RegisterRepositories()
                .RegisterFactories()
                .RegisterPages()
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
            return builder;
        }

        private static MauiAppBuilder RegisterServices(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<IBeeService, BeeService>();
            builder.Services.AddSingleton<IStaticResourcesServices, StaticResourcesServices>();
            return builder;
        }

        private static MauiAppBuilder RegisterFactories(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<IViewModelsFactories, ViewModelsFactories>();
            builder.Services.AddSingleton<IPickerItemFactories, PickerItemFactories>();
            return builder;
        }

        private static MauiAppBuilder RegisterPages(this MauiAppBuilder builder)
        {
            builder.Services.AddTransient<HiveListMainPage>();
            builder.Services.AddTransient<QueenListMainPage>();
            builder.Services.AddTransient<MainPage>();
            return builder;
        }
    }
}
