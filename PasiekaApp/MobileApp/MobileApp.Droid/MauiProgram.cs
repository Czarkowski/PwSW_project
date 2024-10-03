using MobileApp.IInfrastructure;
using MobileApp.Droid.Infrastructure;

namespace MobileApp.Droid
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder
                .UseSharedMauiApp()
                .Services.AddSingleton<IPermissionHelper, PermissionHelper>();
            
            return builder.Build();
        }
    }
}
