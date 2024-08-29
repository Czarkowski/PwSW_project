using MobileApp.ViewModels.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class ReviewListVM : BaseVM
    {
        private ReviewListFilterVM _reviewListFilterVM;
        public ReviewListFilterVM ReviewListFilterVM
        {
            get => _reviewListFilterVM;
            set => SetProperty(ref _reviewListFilterVM, value);
        }
        private List<ReviewListItemVM> _reviewListItemVMs;
        public List<ReviewListItemVM> ReviewListItemVMs
        {
            get => _reviewListItemVMs;
            set => SetProperty(ref _reviewListItemVMs, value);
        }

        private ReviewListItemVM _selectedItem;
        public ReviewListItemVM SelectedItem
        {
            get => _selectedItem;
            set
            {
                if (_selectedItem != value)
                {
                    if (_selectedItem != null)
                        _selectedItem.IsSelected = false;

                    _selectedItem = value;

                    if (_selectedItem != null)
                        _selectedItem.IsSelected = true;

                    OnPropertyChanged(nameof(SelectedItem));
                }
            }
        }

        public void OnItemSelected(ReviewListItemVM selectedItem)
        {
            if (selectedItem != null)
            {
                // Your logic here, e.g., navigate to detail page, update UI, etc.
            }
        }

    }
}
