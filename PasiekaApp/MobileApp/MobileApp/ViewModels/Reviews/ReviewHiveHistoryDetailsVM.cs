using Data.Core.Models;
using MobileApp.ViewModels.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class ReviewHiveHistoryDetailsVM : BaseVM
    {
        private readonly DescriptionHiveReview _descriptionHiveReview;
        public ReviewHiveHistoryDetailsVM(DescriptionHiveReview descriptionHiveReview) : base(descriptionHiveReview.Id)
        {
            _descriptionHiveReview = descriptionHiveReview;
        }
        private string _description;
        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }
    }
}
