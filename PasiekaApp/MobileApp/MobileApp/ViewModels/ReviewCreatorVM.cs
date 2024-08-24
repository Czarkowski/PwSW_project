using Data.Core.Models;
using MobileApp.ViewModels.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class ReviewCreatorVM : BaseVM
    {
        private List<HiveListToCreateReviewVM> _hiveList;
        public List<HiveListToCreateReviewVM> HiveList { get => _hiveList; set => SetProperty(ref _hiveList, value); }
        private List<ReviewType> _reviewTypeList;
        public List<ReviewType> ReviewTypeList { get => _reviewTypeList; set => SetProperty(ref _reviewTypeList, value); }
        private string _description;
        public string Description { get => _description; set => SetProperty(ref _description, value); }
        private DateTime _date;
        public DateTime Date { get => _date; set => SetProperty(ref _date, value); }
        private ReviewType reviewType;
        public ReviewType ReviewType { get => reviewType; set => SetProperty(ref reviewType, value); }

        public List<Hive> SelectedHive => HiveList.FindAll(x => x.IsSelected).Select(x => x.Hive).ToList();
    }
}
