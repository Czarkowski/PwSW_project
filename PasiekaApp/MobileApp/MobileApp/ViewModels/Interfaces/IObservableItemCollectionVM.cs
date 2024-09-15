using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels.Interfaces
{
    public interface IObservableItemCollectionVM<T>
    {
        ObservableCollection<T> ObservableItemCollection { get; set; }
    }
}
