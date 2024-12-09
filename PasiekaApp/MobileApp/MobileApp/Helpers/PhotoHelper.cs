using Data.Core.Models;
using Data.Core;
using MobileApp.Helpers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileApp.Localizations;
using Microsoft.Maui.Platform;

namespace MobileApp.Helpers
{
    public class PhotoHelper : IPhotoHelper
    {
        public async Task<byte[]> TakePhotoBytesAsync()
        {
            try
            {
                var cameraStatus = await Permissions.CheckStatusAsync<Permissions.Camera>();

                if (cameraStatus != PermissionStatus.Granted)
                {
                    cameraStatus = await Permissions.RequestAsync<Permissions.Camera>();
                }

                if (cameraStatus == PermissionStatus.Granted)
                {
                    if (MediaPicker.Default.IsCaptureSupported)
                    {
                        var photoResult = await MediaPicker.CapturePhotoAsync();
                        if (photoResult != null)
                        {
                            var stream = await photoResult.OpenReadAsync();
                            using var memoryStream = new MemoryStream();
                            await stream.CopyToAsync(memoryStream);
                            var imageData = memoryStream.ToArray();
                            return imageData;
                        }
                    }
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert(LocalizeManager.Translate("txt_NoPremission"), LocalizeManager.Translate("txt_NoPermissionForCamera"), LocalizeManager.Translate("txt_OK"));
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert(LocalizeManager.Translate("txt_Error"), LocalizeManager.TranslateWithFormat("txt_Error", ex.Message), LocalizeManager.Translate("txt_OK"));
            }
            return null;
        }
    }
}
