using Data.Core.Models;
using MobileApp.ViewModels.BaseViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class QueenDetailsVM : BaseVM
    {
        //private List<Race> _raceOptions;
        //public List<Race> RaceOptions
        //    {
        //    get
        //    {
        //        return _raceOptions;
        //    }
        //    set
        //    {
        //        SetProperty(ref _raceOptions, value);
        //    }
        //}
        private string _description;
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }

        private Race _race;
        public Race Race
        {
            get
            {
                return _race;
            }
            set
            {
                _race = value;
                OnPropertyChanged(nameof(Race));
            }
        }

        private Hive _hive;
        public Hive Hive
        {
            get
            {
                return _hive;
            }
            set
            {
                _hive = value;
                OnPropertyChanged(nameof(Hive));
            }
        }

        private DateTime _birthDate;
        public DateTime BirthDate
        {
            get
            {
                return _birthDate;
            }
            set
            {
                _birthDate = value;
                OnPropertyChanged(nameof(BirthDate));
            }
        }

    }
}
