using Data.Core.Models;
using MobileApp.ViewModels.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class ReviewHistoryListItemVM : SelectableVM
    {
        public readonly DescriptionHiveReview DescriptionHiveReview;
        public ReviewHistoryListItemVM(DescriptionHiveReview descriptionHiveReview) :base(descriptionHiveReview.Id)
        {
            this.DescriptionHiveReview = descriptionHiveReview;
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
        private string _reviewDescriptiopn;
        public string ReviewDescription
        {
            get => _reviewDescriptiopn;
            set => SetProperty(ref _reviewDescriptiopn, value);
        }
    }
}
