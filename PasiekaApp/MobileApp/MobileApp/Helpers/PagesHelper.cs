using MobileApp.Pages;
using MobileApp.Pages.HiveList.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Helpers
{
    public static class PagesHelper
    {
        private static IServiceProvider serviceProvider => App.Current.Services;

        public static AddQueenPage AddQueen => (AddQueenPage)serviceProvider.GetService(typeof(AddQueenPage));
        public static EditQueenPage EditQueen => (EditQueenPage)serviceProvider.GetService(typeof(EditQueenPage));
        public static QueenListMainPage QueenListMain => (QueenListMainPage)serviceProvider.GetService(typeof(QueenListMainPage));
        public static ChangeQueenPopup ChangeQueenPopup => (ChangeQueenPopup)serviceProvider.GetService(typeof(ChangeQueenPopup));
        public static ReviewCreatorMainPage ReviewCreatorMain => (ReviewCreatorMainPage)serviceProvider.GetService(typeof(ReviewCreatorMainPage));
        public static ReviewListMainPage ReviewListMain => (ReviewListMainPage)serviceProvider.GetService(typeof(ReviewListMainPage));
        public static ReviewDetailsMainPage ReviewDetailsMain => (ReviewDetailsMainPage)serviceProvider.GetService(typeof(ReviewDetailsMainPage));
    }
}
