using Data.Core.Models;
using MobileApp.ViewModels.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class ReviewListFilterVM : BaseVM
    {
        private DateTime? _fromDate;
        private DateTime? _toDate;
        private ReviewType _reviewType;
        private bool? _uncompleted;
        private List<ReviewType> _reviewTypes;
        public DateTime? FromDate { get => _fromDate; set => SetProperty(ref _fromDate, value); }
        public DateTime? ToDate { get => _toDate; set => SetProperty(ref _toDate, value); }
        public ReviewType ReviewType { get => _reviewType; set => SetProperty(ref _reviewType, value); }
        public bool? Uncompleted { get => _uncompleted; set => SetProperty(ref _uncompleted, value); }
        public List<ReviewType> ReviewTypes { get => _reviewTypes; set => SetProperty(ref _reviewTypes, value); }
    }
}
