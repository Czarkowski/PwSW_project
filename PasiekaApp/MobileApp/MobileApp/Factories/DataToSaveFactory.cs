using Data.Core.Models;
using MobileApp.Factories.Interfaces;
using MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Factories
{
    public class DataToSaveFactory : IDataToSaveFactory
    {
        public BeeQueen CreateBeeGueen(QueenDetailsVM queenDetailsVM)
        {
            return new BeeQueen()
            {
                Race = queenDetailsVM.Race,
                BirthDate = queenDetailsVM.BirthDate,
                Description = queenDetailsVM.Description,
            };
        }

        public Description CreateDescription(DescriptionHiveReviewVM descriptionHiveReviewVM)
        {
            return new Description() {
                Text = descriptionHiveReviewVM.Description,
                DescriptionHiveReview = descriptionHiveReviewVM.DescriptionHiveReview,
            };
        }

        public Hive CreateEmptyHive()
        {
            return new Hive()
            {
                Description = string.Empty,
            };
        }

        public Race CreateRace(AddRaceMainVM addRaceMainVM)
        {
            return new Race()
            {
                Name = addRaceMainVM.Name,
                Description = addRaceMainVM.Description,
                IsVisible = true,
            };
        }

        public Review CreateReview(ReviewCreatorVM reviewCreatorVM)
        {
            var descriptionHiveReviewList = reviewCreatorVM.SelectedHive.Select(x =>
                new DescriptionHiveReview()
                {
                    Hive = x
                }).ToList();
            return new Review()
            {
                Description = reviewCreatorVM.Description,
                PlannedDate = reviewCreatorVM.Date,
                ReviewType = reviewCreatorVM.ReviewType,
                DescriptionHiveReviews= descriptionHiveReviewList,
            };
        }

        public StockAvailability CreateStockAvailability(WarehouseItemVM warehouseItemVM)
        {
            return new StockAvailability()
            {
                Name = warehouseItemVM.Name,
                Quantity = warehouseItemVM.Quantity,
                Unit = warehouseItemVM.Unit,
            };
        }
    }
}
