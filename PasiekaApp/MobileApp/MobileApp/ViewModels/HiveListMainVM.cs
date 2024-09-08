using MobileApp.ViewModels.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class HiveListMainVM : BaseVM
    {
        private HiveListVM _hiveListVM;
        public HiveListVM HiveListVM
        {
            get => _hiveListVM;
            set => SetProperty(ref _hiveListVM, value);
        }

        private HiveDetailsVM _hiveDetailsVM;
        public HiveDetailsVM HiveDetailsVM
        {
            get => _hiveDetailsVM;
            set
            {
                SetProperty(ref _hiveDetailsVM, value);
                OnPropertyChanged(nameof(IsHiveDetailsVisible));
            }
        }
        public bool IsHiveDetailsVisible
        {
            get => HiveDetailsVM != null;
        }
    }
}
