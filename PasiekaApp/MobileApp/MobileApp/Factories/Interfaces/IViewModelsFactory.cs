using Data.Core.Models;
using MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Factories.Interfaces
{
    public interface IViewModelsFactory
    {
        List<UlListVM> CreateUlListVMs();
        HiveDetailsVM CreateUlDetailsVM(int ulId);
        QueenDetailsVM CreateQueenDetailsVM(MatkaPszczela matkaPszczela);
        List<QueenListVM> CreateQueenListVM(List<MatkaPszczela> matkaPszczelas);
    }
}
