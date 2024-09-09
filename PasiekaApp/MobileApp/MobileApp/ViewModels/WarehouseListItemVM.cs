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
    public class WarehouseListItemVM : BaseVM, ISelectableVM
    {
        public readonly StockAvailability StockAvailability;
        public WarehouseListItemVM(StockAvailability stockAvailability) : base(stockAvailability.Id)
        {
            StockAvailability = stockAvailability;
        }

        private bool _isSelected;
        public bool IsSelected
        {
            get => _isSelected;
            set => SetProperty(ref _isSelected, value);
        }
        private string _itemName;
        public string ItemName
        {
            get => _itemName;
            set => SetProperty(ref _itemName, value);
        }

        private string _unit;
        public string Unit
        {
            get => _unit;
            set => SetProperty(ref _unit, value);
        }

        private double _quantity;

        public double Quantity
        {
            get => _quantity;
            set => SetProperty(ref _quantity, value);
        }
    }
}
