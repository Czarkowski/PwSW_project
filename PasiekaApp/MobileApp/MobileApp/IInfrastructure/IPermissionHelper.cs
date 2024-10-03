using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.IInfrastructure

{
    public interface IPermissionHelper
    {
        public bool IsNotificationPermissionGranted();
        public bool AskNotificationPermissionGranted();
        public bool IsCameraPermissionGranted();
        public bool AskGetCameraPermissionGranted();
    }
}
