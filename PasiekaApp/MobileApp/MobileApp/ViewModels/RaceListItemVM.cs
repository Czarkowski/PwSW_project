using Data.Core.Models;
using MobileApp.ViewModels.BaseViewModel;
using MobileApp.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class RaceListItemVM : SelectableVM
    {
        public readonly Race Race;
        public RaceListItemVM(Race race) : base(race.Id)
        {
            Race = race;
        }
        private string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
        private bool _isVisible;
        public bool IsVisible
        {
            get => _isVisible;
            set => SetProperty(ref _isVisible, value);
        }
    }
}
