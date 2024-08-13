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
        public int RaceId { get; set; }
        public string Description { get; set; }

        public Rasa Race { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
