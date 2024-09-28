using MobileApp.ViewModels.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class SyrupCalculatorResultsVM : BaseVM
    {
        private double? _resultSyrup;
        private double? _resultSugar;
        private double? _resultWater;

        public SyrupCalculatorResultsVM()
        {
        }

        public SyrupCalculatorResultsVM(double water, double sugar, double syrup)
        {
            this._resultWater = water;
            this._resultSugar = sugar;
            this._resultSyrup = syrup;
        }

        public double? ResultSyrup
        {
            get => _resultSyrup;
            set => SetProperty(ref _resultSyrup, value);
        }
        public double? ResultSugar
        {
            get => _resultSugar;
            set => SetProperty(ref _resultSugar, value);
        }
        public double? ResultWater
        {
            get => _resultWater;
            set => SetProperty(ref _resultWater, value);
        }
    }
}
