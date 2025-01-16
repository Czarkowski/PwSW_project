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
        public ref DescriptionHiveReview UpdateDescriptionHiveReview(ref DescriptionHiveReview descriptionHiveReview, DescriptionHiveReviewVM descriptionHiveReviewVM)
        {
            throw new NotImplementedException();
            //descriptionHiveReview.Description = descriptionHiveReviewVM.Description;
        }

        public ref Hive UpdateHiveDetails(ref Hive hive, HiveDetailsVM hiveVM)
        {
            hive.Description = hiveVM.Description;
            hive.Number = hiveVM.Number;
            hive.AddBeeQueenDate = hiveVM.QueenAddDate;

                hive.BeeQueen = hiveVM.BeeQueen;
                hive.BeeQueenId = hiveVM.BeeQueen?.Id;
                //hive.BeeQueen.Race = hiveVM.BeeQueen.Race;
            
            //if (ul.BeeQueen != null)
            //{
            //    ul.BeeQueen.Hive = ul;
            //}
            return ref hive;
        }

        public ref BeeQueen UpdateQueenDetails(ref BeeQueen beeQueen, QueenDetailsVM queenDetailsVM)
        {
            beeQueen.Description = queenDetailsVM.Description;
            beeQueen.Race = queenDetailsVM.Race;
            beeQueen.BirthDate = queenDetailsVM.BirthDate;
            if (beeQueen.Hive != queenDetailsVM.Hive)
            {
                queenDetailsVM.Hive.AddBeeQueenDate = DateTime.Now.Date;
                beeQueen.Hive = queenDetailsVM.Hive;
            }
            
            return ref beeQueen;
        }

        public ref StockAvailability UpdateStockAvailabilityDetails(ref StockAvailability stock, WarehouseItemVM warehouseItemVM)
        {
            stock.Quantity = warehouseItemVM.Quantity;
            stock.Unit = warehouseItemVM.Unit;
            stock.Name = warehouseItemVM.Name;
            return ref stock;
        }
        public ref Description UpdateDescription(ref Description description, DescriptionHiveReviewVM descriptionHiveReviewVM)
        {
            description.Text = descriptionHiveReviewVM.Description;
            description.Photos = descriptionHiveReviewVM.Photos.Select(x =>
            {
                return x.Photo ?? new Photo()
                {
                    DateTaken = DateTime.Now,
                    ImageData = x.ImageData
                };
            }).ToList();
            return ref description;
        }
    }
}
