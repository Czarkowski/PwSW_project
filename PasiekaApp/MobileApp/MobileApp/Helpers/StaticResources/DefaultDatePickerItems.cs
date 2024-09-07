using Data.Core.Models;
using MobileApp.Localizations;
using System.Security.Cryptography.X509Certificates;

namespace MobileApp.Helpers.StaticResources;

public class DefaultDatePickerItems
{
    public static readonly ReviewType AllReviewType = new ReviewType() { Name = LocalizeManager.Translate("txt_All")};
}