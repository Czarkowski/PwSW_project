using Data.Core.Models;
using MobileApp.ViewModels.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class ReviewListItemVM : BaseVM
    {
        private string _reviewDescription;
        public string ReviewDescription
        {
            get => _reviewDescription;
            set => SetProperty(ref _reviewDescription, value);
        }
        private ReviewType _reviewType;
        public ReviewType ReviewType
        {
            get => _reviewType;
            set => SetProperty(ref _reviewType, value);
        }
        private DateTime _plannedDate;
        public DateTime PlannedDate
        {
            get => _plannedDate;
            set => SetProperty(ref _plannedDate, value);
        }
        private DateTime? _completedDate;
        public DateTime? RealizedDate
        {
            get => _completedDate;
            set => SetProperty(ref _completedDate, value);
        }
    }
}
