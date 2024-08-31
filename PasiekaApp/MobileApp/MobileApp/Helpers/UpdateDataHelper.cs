using Data.Core.Models;
using MobileApp.Helpers.Interfaces;
using MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Helpers
{
    public class UpdateDataHelper : IUpdateDataHelper
    {

        public ref Hive UpdateHiveDetails(ref Hive ul, HiveDetailsVM hive)
        {
            ul.Description = hive.Description;
            ul.Number = hive.Number;
            ul.AddBeeQueenDate = hive.QueenAddDate;
            ul.BeeQueen = hive.BeeQueen;
            return ref ul;
        }

        public ref BeeQueen UpdateQueenDetails(ref BeeQueen beeQueen, QueenDetailsVM queenDetailsVM)
        {
            beeQueen.Description = queenDetailsVM.Description;
            beeQueen.Race = queenDetailsVM.Race;
            beeQueen.BirthDate = queenDetailsVM.BirthDate;
            beeQueen.Hive = queenDetailsVM.Hive;
            return ref beeQueen;
        }

        public ref StockAvailability UpdateStockAvailabilityDetails(ref StockAvailability stock, WarehouseItemVM warehouseItemVM)
        {
            stock.Quantity = warehouseItemVM.Quantity;
            stock.Unit = warehouseItemVM.Unit;
            stock.Name = warehouseItemVM.Name;
            return ref stock;
        }
    }
}
