using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Keys
{
    public struct RouteKeys
    {
        public const string PathPrefix = "//";
        public static readonly string ApiaryDataReviewsMainPage = nameof(ApiaryDataReviewsMainPage);
        public static readonly string ApiaryDataReviewsMainPage_Path = GetRoutePath(ApiaryDataReviewsMainPage);

        public static string GetRoutePath(string routeKey)
        {
            return routeKey.StartsWith(PathPrefix) ? routeKey : routeKey.Insert(0, PathPrefix);
        }
    }
}
