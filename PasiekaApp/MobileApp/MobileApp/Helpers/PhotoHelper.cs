using Data.Core.Models;
using Data.Core;
using MobileApp.Helpers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Helpers
{
    public class PhotoHelper : IPhotoHelper
    {
        public async Task<byte[]> TakePhotoBytesAsync()
        {
            //CrossPermissions
            //Permissions.RequestAsync<Permissions.Camera>();
            var photoResult = await MediaPicker.CapturePhotoAsync();
            if (photoResult != null)
            {
                var stream = await photoResult.OpenReadAsync();
                using var memoryStream = new MemoryStream();
                await stream.CopyToAsync(memoryStream);
                var imageData = memoryStream.ToArray();
                return imageData;
            }
            return null;
        }
    }
}
