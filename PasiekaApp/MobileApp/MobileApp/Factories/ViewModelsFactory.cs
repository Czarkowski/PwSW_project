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

        public List<QueenListVM> CreateQueenListVM(List<MatkaPszczela> matkaPszczelas)
        {
            return matkaPszczelas.Select(x => {


                return new QueenListVM()
                {
                    Id = x.Id,
                    Description = x.Opis ?? string.Empty,
                    BirthDate = x.DataUrodzenia,
                    Age = DateTime.Now - x.DataUrodzenia,
                    Race = x.Rasa.Nazwa,
                    HiveNumber = x.Ul?.Numer,
                };
            }).ToList();
        }

        public HiveDetailsVM CreateUlDetailsVM(int ulId)
        {
            var ul = _beeService.GetUlById(ulId);
            var model = new HiveDetailsVM
            {
                Id = ul.Id,
                Number = ul.Numer,
                Description = ul.Opis ?? string.Empty,
            };
            if (ul.MatkaPszczelaId.HasValue)
            {
            var queen = _beeService.GetQueenById(ul.MatkaPszczelaId.Value);
                if (!queen.IsNull())
                {
                    model.QueenAddDate = ul.DataPoddaniaMatki ?? DateTime.MinValue;
                    model.QueenAge = DateTime.Now - queen.DataUrodzenia;
                    model.QueenDescription = queen.Opis ?? string.Empty;
                }
            }

            return model;
        }

        public List<UlListVM> CreateUlListVMs()
        {
            List<Data.Core.Models.Ul> uls = _beeService.GetAllUls();

            return uls.Select(x => {
                var race = x.MatkaPszczelaId.HasValue ?
                    _beeService.GetRaceByBeeQueenId(x.MatkaPszczelaId.Value)
                    : null;
                return new ViewModels.UlListVM
                {
                    Id = x.Id,
                    Number = x.Numer,
                    Description = x.Opis ?? string.Empty,
                    Race = race?.Nazwa ?? string.Empty,
                };
            }
            ).ToList();
        }
    }
}
