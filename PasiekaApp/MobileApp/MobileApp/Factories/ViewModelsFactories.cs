using Data.Core.Services.Interfaces;
using MobileApp.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Factories
{
    internal class ViewModelsFactories : IViewModelsFactories
    {
        private readonly IBeeService _beeService;
        public ViewModelsFactories(IBeeService beeService) 
        {
            _beeService = beeService;
        }
        public List<ViewModels.UlListVM> CreateUlListVMs()
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
