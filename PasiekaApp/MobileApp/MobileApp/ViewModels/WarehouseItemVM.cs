using MobileApp.ViewModels.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class WarehouseItemVM : BaseVM
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
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
