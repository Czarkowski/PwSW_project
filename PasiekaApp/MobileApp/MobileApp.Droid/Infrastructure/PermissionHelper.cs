using MobileApp.IInfrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Droid.Infrastructure
{
    public class PermissionHelper : IPermissionHelper
    {
        public MainActivity MainActivity { get; set; }
        public bool AskGetCameraPermissionGranted()
        {
            if (!IsNotificationPermissionGranted())
                MainActivity.RequestPermissions(new[] { Android.Manifest.Permission.Camera }, 0);
            return IsCameraPermissionGranted();
        }

        public bool AskNotificationPermissionGranted()
        {
            if (!IsNotificationPermissionGranted())
                MainActivity.RequestPermissions(new[] { Android.Manifest.Permission.PostNotifications }, 0);
            return IsNotificationPermissionGranted();
        }

        public bool IsCameraPermissionGranted()
        {
            return MainActivity.CheckSelfPermission(Android.Manifest.Permission.PostNotifications) != Android.Content.PM.Permission.Granted;
        }

        public bool IsNotificationPermissionGranted()
        {
            return MainActivity.CheckSelfPermission(Android.Manifest.Permission.Camera) != Android.Content.PM.Permission.Granted;
        }
    }
}
