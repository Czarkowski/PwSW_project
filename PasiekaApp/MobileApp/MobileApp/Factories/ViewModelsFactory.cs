using Data.Core.Models;
using Data.Core.Services.Interfaces;
using MobileApp.Factories.Interfaces;
using MobileApp.Helpers.StaticResources;
using MobileApp.Localizations;
using MobileApp.Resources.Languages;
using MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Utilities.StaticExtensions;

namespace MobileApp.Factories
{
    internal class ViewModelsFactory : IViewModelsFactory
    {
        private readonly IBeeService _beeService;
        public ViewModelsFactory(IBeeService beeService) 
        {
            _beeService = beeService;
        }

        public DescriptionHiveReviewVM CreateDescriptionHiveReviewVM(DescriptionHiveReview descriptionHiveReview)
        {
            return new DescriptionHiveReviewVM(descriptionHiveReview)
            {
                Description = descriptionHiveReview.Description?.Text ?? string.Empty,
                HiveName = $"{descriptionHiveReview.Hive.Number} - {descriptionHiveReview.Hive.BeeQueen?.Race.Name ?? LocalizeManager.Translate("txt_NoQueen")}",
            };
        }

        public WarehouseItemVM CreateEmptyWarehouseItemVM()
        {
            return new WarehouseItemVM()
            {
                Name = string.Empty,
                Quantity = 0,
                Unit = string.Empty,
            };
        }

        public HiveListMainVM CreateHiveListMainVM(List<Hive> hives)
        {
            return new HiveListMainVM()
            {
                HiveListVM = new HiveListVM()
                {
                    HiveListItemVMs = hives.Select(x => new HiveListItemVM(x)
                    {
                        Number = x.Number,
                        Description = x.Description,
                        Race = x.BeeQueenId.HasValue ? _beeService.GetRaceByBeeQueenId(x.BeeQueenId.Value).Name : string.Empty,

                    }).ToList(),
                }
            };
        }

        public List<HiveListToCreateReviewVM> CreateHiveListToCreateReviewVM(List<Hive> hives)
        {
            return hives.Select(x => new HiveListToCreateReviewVM
            {
                Hive = x,
                IsSelected = false,
            }).ToList();
        }

        public QueenDetailsVM CreateQueenDetailsVM(BeeQueen matkaPszczela)
        {
            return new QueenDetailsVM()
            {
                BirthDate = matkaPszczela.BirthDate,
                Description = matkaPszczela.Description ?? string.Empty,
                Hive = matkaPszczela.Hive,
                Race = matkaPszczela.Race,
            };
        }

        public List<QueenListVM> CreateQueenListVM(List<BeeQueen> matkaPszczelas)
        {
            return matkaPszczelas.Select(x => {


                return new QueenListVM()
                {
                    Id = x.Id,
                    Description = x.Description ?? string.Empty,
                    BirthDate = x.BirthDate,
                    Age = DateTime.Now - x.BirthDate,
                    Race = x.Race.Name,
                    HiveNumber = x.Hive?.Number,
                };
            }).ToList();
        }

        public ReviewCreatorVM CreateReviewCreatorVM(List<HiveListToCreateReviewVM> hiveListToCreateReviewVMs, List<ReviewType> reviewType)
        {
            return new ReviewCreatorVM()
            {
                HiveList = hiveListToCreateReviewVMs,
                ReviewTypeList = reviewType,
                Date = DateTime.Now.Date,
                Description = string.Empty,
                ReviewType = reviewType?.FirstOrDefault(),
            };
        }

        public ReviewDetailsVM CreateReviewDetailsVM(Review review)
        {
            return new ReviewDetailsVM(review)
            {
                Description = review.Description,
                PlannedDate = review.PlannedDate,
                RealizedDate = review.RealizedDate,
                ReviewTypeName = review.ReviewType.Name,
                DescriptionHiveReviewVMs = review.DescriptionHiveReviews.Select(CreateDescriptionHiveReviewVM).ToList(),
            };
        }

        public ReviewHiveHistoryVM CreateReviewHistoryVM(Hive hive)
        {
            return new ReviewHiveHistoryVM()
            {
                ReviewHistoryListFilterVM = CreateReviewListFilterVM(),
                ReviewHistoryListVM = new ReviewHistoryListVM()
                {
                    ReviewHistoryListItemVMs = hive.DescriptionHiveReviews.Select(x => new ReviewHistoryListItemVM(x)
                    {
                        Description = x.Description?.Text ?? string.Empty,
                        PlannedDate = x.Review.PlannedDate,
                        RealizedDate = x.Review.RealizedDate,
                        ReviewDescription = x.Review.Description,
                        ReviewTypeName = x.Review.ReviewType.Name,
                    }).ToList(),
                },
            };
        }

        public ReviewListFilterVM CreateReviewListFilterVM()
        {
            var reviewTypes = _beeService.GetAllReviewType();
            reviewTypes.Add(DefaultDatePickerItems.AllReviewType);
            return new ReviewListFilterVM()
            {
                FromDate = DateTime.Now.Date.AddDays(-7),
                ToDate = DateTime.Now.Date.AddDays(14),
                ReviewType = null,
                Uncompleted = true,
                ReviewTypes = reviewTypes,
            };
        }

        public ReviewListItemVM CreateReviewListItemVM(Review review)
        {
            return new ReviewListItemVM(review)
            {
                ReviewDescription = review.Description,
                ReviewType = review.ReviewType,
                RealizedDate = review.RealizedDate,
                PlannedDate = review.PlannedDate,
            };
        }

        public List<ReviewListItemVM> CreateReviewListItemVMs(List<Review> reviews)
        {
            return reviews.Select(CreateReviewListItemVM).ToList();
        }

        public ReviewListVM CreateReviewListVM(List<Review> reviews, ReviewListFilterVM filterVM)
        {
            return new ReviewListVM()
            {
                ReviewListItemVMs = reviews.Select(CreateReviewListItemVM).ToList(),
                ReviewListFilterVM = filterVM,
            };
        }

        public HiveDetailsVM CreateHiveDetailsVM(Hive hive)
        {
            var model = new HiveDetailsVM(hive)
            {
                Number = hive.Number,
                Description = hive.Description ?? string.Empty,
            };
            if (hive.BeeQueenId.HasValue)
            {
            var queen = _beeService.GetQueenById(hive.BeeQueenId.Value);
                if (!queen.IsNull())
                {
                    model.BeeQueen = queen;
                    model.QueenAddDate = hive.AddBeeQueenDate ?? DateTime.MinValue;
                    model.QueenAge = DateTime.Now - queen.BirthDate;
                    model.QueenDescription = queen.Description ?? string.Empty;
                }
            }
            else
            {
                model.QueenAddDate = DateTime.MinValue;
            }

            return model;
        }

        public List<HiveListItemVM> CreateUlListVMs()
        {
            List<Data.Core.Models.Hive> uls = _beeService.GetAllHive();

            return uls.Select(x => {
                var race = x.BeeQueenId.HasValue ?
                    _beeService.GetRaceByBeeQueenId(x.BeeQueenId.Value)
                    : null;
                return new ViewModels.HiveListItemVM(x)
                {
                    Number = x.Number,
                    Description = x.Description ?? string.Empty,
                    Race = race?.Name ?? string.Empty,
                };
            }
            ).ToList();
        }

        public WarehouseVM CreateWarehouseVM(List<StockAvailability> stockAvailabilities)
        {
            return new WarehouseVM()
            {
                SearchPhrase = string.Empty,
                SelectedItem = null,
                NewWarehouseItemVM = CreateEmptyWarehouseItemVM(),
                WarehouseListItemVMs = stockAvailabilities.Select(x => new WarehouseListItemVM(x)
                {
                    ItemName = x.Name,
                    Quantity = x.Quantity,
                    Unit = x.Unit,
                }).ToList(),
            };
        }

        public AddQueenVM CreateAddQueenVM(List<Race> races)
        {
            return new AddQueenVM()
            {
                QueenDetailsVM = new QueenDetailsVM()
                {
                    BirthDate = DateTime.Now,
                    Description = string.Empty,
                },
                Races = races,
            };
        }

        public AddRaceMainVM CreateAddRaceMainVM()
        {
            return new AddRaceMainVM()
            {
                Description = string.Empty,
                Name = string.Empty,
            };
        }

        public ApiaryDataRacesMainVM CreateApiaryDataRacesMainVM(List<Race> races)
        {
            return new ApiaryDataRacesMainVM()
            {
                NewRaceName = string.Empty,
                RacesListVM = new RacesListVM()
                {
                    ItemList = races.Select(x => new RaceItemVM(x)
                    {
                        Name = x.Name,
                        IsVisible = x.IsVisible,
                    }).ToList(),
                },
                AddRaceMainVM = CreateAddRaceMainVM(),
            };
        }
    }
}
