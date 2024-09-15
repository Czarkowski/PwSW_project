using MobileApp.ViewModels.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class ApiaryDataRacesMainVM : BaseVM
    {
        private RacesListVM _racesListVM;
        public RacesListVM RacesListVM
        {
            get => _racesListVM;
            set => SetProperty(ref _racesListVM, value);
        }

        private AddRaceMainVM _addRaceMainVM;
        public AddRaceMainVM AddRaceMainVM
        {
            get => _addRaceMainVM;
            set => SetProperty(ref _addRaceMainVM, value);
        }
    }
}
