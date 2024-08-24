using Data.Core.Models;
using MobileApp.ViewModels.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class HiveListToCreateReviewVM : BaseVM
    {
        private bool _isSelected;
        public bool IsSelected
        {
            get => _isSelected;
            set => SetProperty(ref _isSelected, value);
        }
        private Ul _hive;
        public Ul Hive 
        { 
            get => _hive;
            set => SetProperty(ref _hive, value);
        }

        public override string ToString()
        {
            return $"{Hive.Numer} - {Hive.MatkaPszczela?.Rasa?.Nazwa ?? "Without Queen!"}";  
        }
    }
}
