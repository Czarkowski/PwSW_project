using Data.Core.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Converters
{
    public class BeeQueenNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value == null)
                return "Brak";

            if (value is MatkaPszczela item)
            {
                return $"{item.Id}:{item.Rasa.Nazwa}:{item.DataUrodzenia.ToShortDateString()}";
            }
            return value.ToString();
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
