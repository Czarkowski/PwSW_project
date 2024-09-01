using MobileApp.ViewModels.BaseViewModel;
using MobileApp.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class WarehouseVM : HaveSelectionVM<WarehouseListItemVM>
    {
        public WarehouseVM()
        {
        }
        private string _searchPhrase;
        public string SearchPhrase
        {
            get => _searchPhrase;
            set => SetProperty(ref _searchPhrase, value);
        }
        private List<WarehouseListItemVM> _warehouseListItemVMs;
        public List<WarehouseListItemVM> WarehouseListItemVMs
        {
            get => _warehouseListItemVMs;
            set { SetProperty(ref _warehouseListItemVMs, value); ApplyFilter(); }
        }

        public ObservableCollection<WarehouseListItemVM> FiltratedWarehouseListItemVMs { get; private set; }

        public void ApplyFilter()
        {
            FiltratedWarehouseListItemVMs = new ObservableCollection<WarehouseListItemVM>(WarehouseListItemVMs.Where(x => x.ItemName.Contains(SearchPhrase, StringComparison.OrdinalIgnoreCase)));
            OnPropertyChanged(nameof(FiltratedWarehouseListItemVMs));
        }

        private WarehouseItemVM _newWarehouseItemVM;
        public WarehouseItemVM NewWarehouseItemVM
        {
            get => _newWarehouseItemVM;
            set => SetProperty(ref _newWarehouseItemVM, value);
        }
    }
}
