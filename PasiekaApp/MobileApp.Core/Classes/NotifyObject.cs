using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Core.Classes
{
    public class NotifyObject<T> : INotifyPropertyChanged
    {
        public NotifyObject(T value)
        {
            _value = value;
        }

        private T _value;
        public T Value
        {
            get { return _value; }
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public static implicit operator T(NotifyObject<T> obj)
        {
            return obj.Value;
        }
        public static implicit operator NotifyObject<T>(T obj)
        {
            return new NotifyObject<T>(obj);
        }
    }
}
