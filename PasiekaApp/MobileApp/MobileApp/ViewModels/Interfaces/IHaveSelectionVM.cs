using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels.Interfaces
{
    public interface IHaveSelectionVM<T> where T : class
    {
        T SelectedItem { get; set; }
    }
}
