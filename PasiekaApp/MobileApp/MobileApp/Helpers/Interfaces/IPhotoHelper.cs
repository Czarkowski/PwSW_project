using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Helpers.Interfaces
{
    public interface IPhotoHelper
    {
        public Task<byte[]> TakePhotoBytesAsync();
    }
}
