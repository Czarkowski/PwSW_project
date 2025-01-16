using Data.Core.Models;
using MobileApp.ViewModels.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class ReviewDetailsVM : HaveSelectionVM<DescriptionHiveReviewVM>
    {
        public readonly Review Review;
        public ReviewDetailsVM(Review review): base(review.Id) 
        {
            Review = review;
        }

        private string _description;
        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }

        private string _reviewTypeName;
        public string ReviewTypeName
        {
            get => _reviewTypeName;
            set => SetProperty(ref _reviewTypeName, value);
        }

        private DateTime _plannedDate;
        public DateTime PlannedDate
        {
            get => _plannedDate;
            set => SetProperty(ref _plannedDate, value);
        }
        private DateTime? _realizedDate;
        public DateTime? RealizedDate
        {
            get => _realizedDate;
            set => SetProperty(ref _realizedDate, value);
        }
        private List<DescriptionHiveReviewVM> _descriptionHiveReviewVMs;
        public List<DescriptionHiveReviewVM> DescriptionHiveReviewVMs
        {
            get => _descriptionHiveReviewVMs;
            set => SetProperty(ref _descriptionHiveReviewVMs, value);
        }
        public bool IsNoComplete => !RealizedDate.HasValue;
    }
}
