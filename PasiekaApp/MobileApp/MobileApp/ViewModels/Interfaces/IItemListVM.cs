using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels.Interfaces
{
    public interface IItemListVM<T> where T : ISelectableVM
    {
        public List<T> ItemList { get; set; }
    }
}
