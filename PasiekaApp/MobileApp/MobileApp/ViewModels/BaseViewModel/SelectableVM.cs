using MobileApp.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels.BaseViewModel
{
    public abstract class SelectableVM : BaseVM, ISelectableVM
    {
        public SelectableVM() { }
        public SelectableVM(int id) : base(id) { }
        protected bool _isSelected;
        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }
    }
}
