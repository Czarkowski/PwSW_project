using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Core.BasePages
{
    public class BaseContentPage<T> : ContentPage where T : class
    {
        protected T _viewModel;
        public T ViewModel
        {
            get { return _viewModel; }
            set { _viewModel = value; OnPropertyChanged(); }
        }
    }
}
