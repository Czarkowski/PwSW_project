using Data.Core.Models;
using MobileApp.ViewModels.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class ProductionTypeDetailsVM : BaseVM
    {
        public readonly ProductionType ProductionType;
        public bool IsReference => ProductionType != null;
        public ProductionTypeDetailsVM(ProductionType productionType) : base(productionType?.Id)
        {
            ProductionType = productionType;
        }
        private string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
        private string _description;
        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }
    }
}
