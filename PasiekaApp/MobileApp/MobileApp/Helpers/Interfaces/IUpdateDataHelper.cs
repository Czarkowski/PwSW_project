using Data.Core.Models;
using MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Helpers.Interfaces
{
    public interface IUpdateDataHelper
    {
        ref BeeQueen UpdateQueenDetails(ref BeeQueen matkaPszczela, QueenDetailsVM queenDetailsVM);
        ref Hive UpdateHiveDetails(ref Hive ul, HiveDetailsVM hive);
        ref StockAvailability UpdateStockAvailabilityDetails(ref StockAvailability stock, WarehouseItemVM warehouseItemVM);
    }
}
