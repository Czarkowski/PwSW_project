using Data.Core.Models;
using MobileApp.ViewModels.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class HiveListItemVM : SelectableVM
    {
        public readonly Hive Hive;
        public HiveListItemVM(Hive hive) : base(hive.Id)
        {
            Hive = hive;
        }
        private int _number;
        public int Number
        {
            get => _number;
            set => SetProperty(ref _number, value);
        }
        private string _description;
        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }
        private string _race;
        public string Race
        {
            get => _race;
            set => SetProperty(ref _race, value);
        }

        public override string ToString()
        {
            return $"{Number} - {Race}";
        }
    }
}
