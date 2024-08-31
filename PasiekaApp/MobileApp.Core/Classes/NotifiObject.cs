using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Core.Classes
{
    public class NotifiObject<T> : INotifyPropertyChanged
    {
        public NotifiObject(T value)
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
        public static implicit operator T(NotifiObject<T> obj)
        {
            return obj.Value;
        }
        public static implicit operator NotifiObject<T>(T obj)
        {
            return new NotifiObject<T>(obj);
        }
    }
}
