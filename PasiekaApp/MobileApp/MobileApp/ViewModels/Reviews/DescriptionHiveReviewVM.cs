﻿using Data.Core.Models;
using MobileApp.ViewModels.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class DescriptionHiveReviewVM : SelectableVM
    {
        public readonly DescriptionHiveReview DescriptionHiveReview;
        public DescriptionHiveReviewVM(DescriptionHiveReview descriptionHiveReview) : base(descriptionHiveReview.Id)
        {
            DescriptionHiveReview = descriptionHiveReview;
        }
        private string _description;
        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }
        private string _hiveName;
        public string HiveName
        {
            get => _hiveName;
            set => SetProperty(ref _hiveName, value);
        }
    }
}