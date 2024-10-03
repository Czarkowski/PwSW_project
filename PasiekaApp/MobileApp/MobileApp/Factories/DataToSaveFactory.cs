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
                Photos = descriptionHiveReviewVM.Photos.Select(x => 
                    new Photo() {
                        DateTaken = DateTime.Now,
                        ImageData = x.ImageData
                }).ToList(),
            };
        }

        public Hive CreateEmptyHive()
        {
            return new Hive()
            {
                Description = string.Empty,
            };
        }

        public ProductionType CreateProductionType(ProductionTypeDetailsVM productionTypeDetailsVM)
        {
            return new ProductionType()
            {
                Name = productionTypeDetailsVM.Name,
                Description = productionTypeDetailsVM.Description,
                IsVisible = true,
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
                PlannedDate = reviewCreatorVM.Date.Date,
                ReviewType = reviewCreatorVM.ReviewType,
                DescriptionHiveReviews= descriptionHiveReviewList,
            };
        }

        public ReviewType CreateReviewType(AddReviewTypeVM addReviewTypeVM)
        {
            return new ReviewType()
            {
                Name = addReviewTypeVM.Name,
                Description = addReviewTypeVM.Description,
                IsVisible = true,
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
