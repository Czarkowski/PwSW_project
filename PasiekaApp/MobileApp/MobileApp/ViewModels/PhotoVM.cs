using Data.Core.Models;
using MobileApp.ViewModels.BaseViewModel;

namespace MobileApp.ViewModels;

public class PhotoVM : BaseVM
{
	public readonly Photo Photo;
    public PhotoVM(Photo photo = null) : base(photo?.Id)
    {
        Photo = photo;
    }

    private byte[] _photoData;
    public byte[] ImageData
    {
        get => _photoData;
        set => SetProperty(ref _photoData, value);
    }
}