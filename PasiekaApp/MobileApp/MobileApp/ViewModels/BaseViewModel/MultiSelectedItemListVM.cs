using Data.Core.Models;
using MobileApp.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MobileApp.ViewModels.BaseViewModel
{
    public class MultiSelectedItemLIstVM<T> : BaseVM, IMultiSelectedItemListVM<T> where T : class, ISelectableVM
    {
        public MultiSelectedItemLIstVM(List<T> list)
        {
            SelectedItems = new List<T>();

            OnSelectedCommand = new Command<SelectionChangedEventArgs>(OnSelected);
        }
        public ICommand OnSelectedCommand { get; }
        private List<T> _selectedItems;
        public List<T> SelectedItems { get => _selectedItems; set => SetProperty(ref _selectedItems, value); }
        //private T _selectedItem;
        //public T SelectedItem { get => _selectedItem; set => SetProperty(ref _selectedItem, value); }
        private List<T> _itemList;
        public List<T> ItemList { get => _itemList; set => SetProperty(ref _itemList, value); }

        private void OnSelected(SelectionChangedEventArgs eventArgs)
        {
            if (eventArgs == null)
                return;
            // Nowo zaznaczone elementy
            var addedItems = eventArgs.CurrentSelection.Except(eventArgs.PreviousSelection).Cast<T>();
            // Nowo odznaczone elementy
            var removedItems = eventArgs.PreviousSelection.Except(eventArgs.CurrentSelection).Cast<T>();

            foreach (var item in addedItems)
            {
                SelectedItems.Add(item);
            }

            foreach (var item in removedItems)
            {
                SelectedItems.Remove(item);
            }
        }
    }
}
