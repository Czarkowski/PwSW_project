using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Core.BasePages
{
    public abstract class BaseContentPage<T> : ContentPage where T : class
    {
        protected T _viewModel;
        public T ViewModel
        {
            get { return _viewModel; }
            set { _viewModel = value; OnPropertyChanged(); }
        }

        protected abstract void LoadData();

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (ViewModel == null)
            {
                LoadData();
            }
        }

        public BaseContentPage()
        {
            //BindingContext = ViewModel;
        }
    }
}
