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
        public static readonly string ApiaryDataProdutionsMainPage = nameof(ApiaryDataProdutionsMainPage);
        public static readonly string ApiaryDataRacesMainPage = nameof(ApiaryDataRacesMainPage);
        public static readonly string ApiaryDataReviewsMainPage_Path = GetRoutePath(ApiaryDataReviewsMainPage);
        public static readonly string ApiaryDataRacesMainPage_Path = GetRoutePath(ApiaryDataRacesMainPage);
        public static readonly string ApiaryDataProdutionsMainPage_Path = GetRoutePath(ApiaryDataProdutionsMainPage);

        public static string GetRoutePath(string routeKey)
        {
            return routeKey.StartsWith(PathPrefix) ? routeKey : routeKey.Insert(0, PathPrefix);
        }
    }
}
