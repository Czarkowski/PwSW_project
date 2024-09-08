using Data.Core.Models;
using MobileApp.ViewModels.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class AddQueenVM : BaseVM
    {
        private QueenDetailsVM _queenDetailsVM;
        public QueenDetailsVM QueenDetailsVM
        {
            get => _queenDetailsVM;
            set => SetProperty(ref _queenDetailsVM, value);
        }
        private List<Race> _races;
        public List<Race> Races
        {
            get => _races;
            set => SetProperty(ref _races, value);
        }
    }
}
