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
                    Race = x.Race.Nazwa,
                    HiveNumber = x.Hive?.Number,
                };
            }).ToList();
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
                    Race = race?.Nazwa ?? string.Empty,
                };
            }
            ).ToList();
        }
    }
}
