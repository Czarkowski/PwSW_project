using Data.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class QueenDetailsVM : INotifyPropertyChanged
    {
        //private int _raceId;
        //public int RaceId { 
        //    get
        //    {
        //        return _raceId;
        //    } 
        //    set 
        //    {
        //        _raceId = value;
        //        OnPropertyChanged(nameof(RaceId));
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

        private Rasa _rasa;
        public Rasa Race
        {
            get
            {
                return _rasa;
            }
            set
            {
                _rasa = value;
                OnPropertyChanged(nameof(Rasa));
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

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
