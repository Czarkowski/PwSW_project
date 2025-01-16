using Data.Core.Models;
using MobileApp.Localizations;
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
        private Hive _hive;
        public Hive Hive 
        { 
            get => _hive;
            set => SetProperty(ref _hive, value);
        }

        public override string ToString()
        {
            return $"{Hive.Number} - {Hive.BeeQueen?.Race?.Name ?? LocalizeManager.Translate("txt_NoQueen")}";  
        }
    }
}
