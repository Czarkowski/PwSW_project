using MobileApp.ViewModels.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class ApiaryToolSyrupCalculatorMainVM : BaseVM
    {
        private RatioListVM _ratioListVM;
        public RatioListVM RatioListVM
        {
            get => _ratioListVM;
            set => SetProperty(ref _ratioListVM, value);
        }

        private CalculationTypeListVM _calculationTypeListVM;
        public CalculationTypeListVM CalculationTypeListVM
        {
            get => _calculationTypeListVM;
            set => SetProperty(ref _calculationTypeListVM, value);
        }

        private SyrupCalculatorResultsVM _syrupCalculatorResultsVM;
        public SyrupCalculatorResultsVM SyrupCalculatorResultsVM
        {
            get => _syrupCalculatorResultsVM;
            set => SetProperty(ref _syrupCalculatorResultsVM, value);
        }

        private double _inputValue;
        public double InputValue
        {
            get => _inputValue;
            set => SetProperty(ref _inputValue, value);
        }
    }
}
