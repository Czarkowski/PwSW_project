using MobileApp.ApiaryTools;
using MobileApp.ViewModels.BaseViewModel;
using MobileApp.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class ApiaryToolSyrupCalculatorMainVM : BaseVM
    {
        private PickerItemListVM<SyrupCalculationRatioType> _calculationRatioListVM;
        public PickerItemListVM<SyrupCalculationRatioType> CalculationRatioListVM
        {
            get => _calculationRatioListVM;
            set => SetProperty(ref _calculationRatioListVM, value);
        }

        private PickerItemListVM<SyrupCalculationBaseType> _calculationTypeListVM;
        public PickerItemListVM<SyrupCalculationBaseType> CalculationTypeListVM
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
