using MobileApp.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels.BaseViewModel
{
    public class HaveSelectionVM<T> : BaseVM, IHaveSelection<T> where T : class, ISelectable
    {
        public HaveSelectionVM() { }
        public HaveSelectionVM(int id) : base(id) { }
        protected T _selectedItem;
        public T SelectedItem
        {
            get => _selectedItem;
            set
            {
                if (_selectedItem != value)
                {
                    if (_selectedItem != null)
                        _selectedItem.IsSelected = false;

                    _selectedItem = value;

                    if (_selectedItem != null)
                        _selectedItem.IsSelected = true;

                    OnPropertyChanged(nameof(SelectedItem));
                }
            }
        }
    }
}
