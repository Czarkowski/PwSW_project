using Data.Core.Models;
using Data.Core.Services.Interfaces;
using MobileApp.Factories.Interfaces;
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
                Id = matkaPszczela.Id,
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

        public ReviewListFilterVM CreateReviewListFilterVM()
        {
            var reviewTypes = _beeService.GetAllReviewType();
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
            return new ReviewListItemVM()
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

        public HiveDetailsVM CreateUlDetailsVM(int ulId)
        {
            var ul = _beeService.GetHiveById(ulId);
            var model = new HiveDetailsVM
            {
                Id = ul.Id,
                Number = ul.Number,
                Description = ul.Description ?? string.Empty,
            };
            if (ul.BeeQueenId.HasValue)
            {
            var queen = _beeService.GetQueenById(ul.BeeQueenId.Value);
                if (!queen.IsNull())
                {
                    model.BeeQueen = queen;
                    model.QueenAddDate = ul.AddBeeQueenDate ?? DateTime.MinValue;
                    model.QueenAge = DateTime.Now - queen.BirthDate;
                    model.QueenDescription = queen.Description ?? string.Empty;
                }
            }

            return model;
        }

        public List<UlListVM> CreateUlListVMs()
        {
            List<Data.Core.Models.Hive> uls = _beeService.GetAllHive();

            return uls.Select(x => {
                var race = x.BeeQueenId.HasValue ?
                    _beeService.GetRaceByBeeQueenId(x.BeeQueenId.Value)
                    : null;
                return new ViewModels.UlListVM
                {
                    Id = x.Id,
                    Number = x.Number,
                    Description = x.Description ?? string.Empty,
                    Race = race?.Name ?? string.Empty,
                };
            }
            ).ToList();
        }
    }
}
