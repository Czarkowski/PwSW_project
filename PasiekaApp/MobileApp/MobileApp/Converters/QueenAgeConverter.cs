using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Converters
{
    public class QueenAgeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is TimeSpan timeSpan)
            {
                int totalMonths = (int)(timeSpan.TotalDays / 30); // Szybki sposób na uzyskanie miesięcy
                int years = totalMonths / 12;
                int months = totalMonths % 12;

                return $"{years} Lata - {months} Miesiące";
            }
            return "N/A"; // Wartość domyślna, gdy TimeSpan jest null
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
