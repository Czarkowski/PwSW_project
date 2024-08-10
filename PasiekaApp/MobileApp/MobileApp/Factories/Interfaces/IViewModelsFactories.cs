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
    }
}
