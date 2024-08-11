using Data.Core.Models;
using MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Factories.Interfaces
{
    public interface IViewModelsFactories
    {
        List<UlListVM> CreateUlListVMs();
        UlDetailsVM CreateUlDetailsVM(int ulId);
        List<QueenListVM> CreateQueenListVM(List<MatkaPszczela> matkaPszczelas);
    }
}
