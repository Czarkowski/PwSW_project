using MobileApp.ViewModels.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class ApiaryDataProductionsMainVM : BaseVM
    {
        private ProductionTypeListVM _productionTypeListVM;
        public ProductionTypeListVM ProductionTypeListVM 
        { 
            get => _productionTypeListVM; 
            set => SetProperty(ref _productionTypeListVM, value); 
        }
        private ProductionTypeDetailsVM _productionTypeDetailsVM;
        public ProductionTypeDetailsVM ProductionTypeDetailsVM 
        { 
            get => _productionTypeDetailsVM; 
            set => SetProperty(ref _productionTypeDetailsVM, value); 
        }
    }
}
