using MobileApp.Pages.Review.List.Templates;
using MobileApp.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels.BaseViewModel
{
    public abstract class ObservableItemCollectionVM<T> : ItemListVM<T>, IObservableItemCollectionVM<T> where T : class, ISelectableVM
    {
        private ObservableCollection<T> _observableItemCollection;
        public ObservableCollection<T> ObservableItemCollection 
        {
            get => _observableItemCollection;
            set => SetProperty(ref _observableItemCollection, value);
        }

        public override List<T> ItemList {
            get 
            { 
                return ObservableItemCollection.ToList(); 
            }
            set 
            {
                ObservableItemCollection = new ObservableCollection<T>(value);
                base.ItemList = value;
            }
        }
    }
}
