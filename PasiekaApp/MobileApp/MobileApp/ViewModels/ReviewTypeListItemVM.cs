using Data.Core.Models;
using MobileApp.ViewModels.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class ReviewTypeListItemVM : SelectableVM
    {
        public readonly ReviewType ReviewType;
        public ReviewTypeListItemVM(ReviewType reviewType) : base(reviewType.Id)
        {
            ReviewType = reviewType;
        }
        private string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
        private bool _isVisible;
        public bool IsVisible
        {
            get => _isVisible;
            set => SetProperty(ref _isVisible, value);
        }
    }
}
