using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Plugin.LocalNotification;
using Plugin.LocalNotification.EventArgs;

namespace MobileApp.Droid
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            if (Build.VERSION.SdkInt >= BuildVersionCodes.Tiramisu)
            {
                if (CheckSelfPermission(Android.Manifest.Permission.PostNotifications) != Android.Content.PM.Permission.Granted)
                {
                    RequestPermissions(new[] { Android.Manifest.Permission.PostNotifications }, 0);
                }
            }
            if (CheckSelfPermission(Android.Manifest.Permission.PostNotifications) == Android.Content.PM.Permission.Granted)
            {
                CreateNotificationChannel();
                LocalNotificationCenter.Current.NotificationActionTapped += OnNotificationTapped;
            }


            if (CheckSelfPermission(Android.Manifest.Permission.Camera) != Android.Content.PM.Permission.Granted)
            {
                RequestPermissions(new[] { Android.Manifest.Permission.Camera }, 0);
            }
        }

        private void CreateNotificationChannel()
        {
            if (Build.VERSION.SdkInt >= BuildVersionCodes.O)
            {
                var channelId = "PszczelaEnklawaNotifyChannelId";
                var channelName = "Pszczela Enklawa Notify Channel";
                //var channelDescription = "Kana³ powiadomieñ domyœlny";
                var channel = new NotificationChannel(channelId, channelName, NotificationImportance.Default)
                {
                    //Description = channelDescription
                };

                var notificationManager = (NotificationManager)GetSystemService(NotificationService);
                notificationManager.CreateNotificationChannel(channel);
            }
        }

        private void OnNotificationTapped(NotificationEventArgs e)
        {
            // Obs³uga klikniêcia powiadomienia
        }
    }
}
