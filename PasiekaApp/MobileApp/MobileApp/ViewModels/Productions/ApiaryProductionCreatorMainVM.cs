using Data.Core.Models;
using MobileApp.ApiaryTools;
using MobileApp.Productions;
using MobileApp.ViewModels.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class ApiaryProductionCreatorMainVM : BaseVM
    {
        public ApiaryProductionCreatorMainVM() { }

        private PickerItemListVM<UnitType> _unitTypePickerVM;
        public PickerItemListVM<UnitType> UnitTypePickerVM
        {
            get => _unitTypePickerVM;
            set => SetProperty(ref _unitTypePickerVM, value);
        }

        private PickerItemListVM<ProductionType> _productionTypePickerVM;
        public PickerItemListVM<ProductionType> ProductionTypePickerVM
        {
            get => _productionTypePickerVM;
            set => SetProperty(ref _productionTypePickerVM, value);
        }

        private MultiSelectedItemLIstVM<HiveListItemVM> _hiveListVM;
        public MultiSelectedItemLIstVM<HiveListItemVM> HiveListVM
        {
            get => _hiveListVM;
            set => SetProperty(ref _hiveListVM, value);
        }

        private decimal _inputValue;
        public decimal InputValue
        {
            get => _inputValue;
            set => SetProperty(ref _inputValue, value);
        }
    }
}
