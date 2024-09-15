using MobileApp.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels.BaseViewModel
{
    public abstract class ItemListVM<T> : HaveSelectionVM<T>, IItemListVM<T> where T : class, ISelectableVM 
    {
        private List<T> _itemList;
        public virtual List<T> ItemList
        {
            get => _itemList;
            set => SetProperty(ref _itemList, value);
        }
    }
}
