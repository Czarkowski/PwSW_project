using MobileApp.Pages;
using MobileApp.Pages.HiveList.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.StaticProviders
{
    public static class PagesProvider
    {
        private static IServiceProvider serviceProvider  => App.Current.Services;

        public static AddQueenPage AddQueen => (AddQueenPage)serviceProvider.GetService(typeof(AddQueenPage));
        public static EditQueenPage EditQueen => (EditQueenPage)serviceProvider.GetService(typeof(EditQueenPage));
        public static QueenListMainPage QueenListMain => (QueenListMainPage)serviceProvider.GetService(typeof(QueenListMainPage));
        public static ChangeQueenPopup ChangeQueenPopup => (ChangeQueenPopup)serviceProvider.GetService(typeof(ChangeQueenPopup));
        public static ReviewCreatorMainPage ReviewCreatorMain => (ReviewCreatorMainPage)serviceProvider.GetService(typeof(ReviewCreatorMainPage));
        public static ReviewMainPage ReviewMain => (ReviewMainPage)serviceProvider.GetService(typeof(ReviewMainPage));
    }
}
