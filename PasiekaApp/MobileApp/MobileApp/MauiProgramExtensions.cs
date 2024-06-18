using Data.Core;
using Microsoft.Extensions.Logging;

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
            builder.Services.AddSingleton<IBeeService>(provider =>
            {
                return new BeeService();
            });
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
    }
}
