using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Utilities.StaticExtensions
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum enumValue)
        {
            // Pobierz typ enuma
            var enumType = enumValue.GetType();

            // Pobierz pole odpowiadające wartości enum
            var memberInfo = enumType.GetMember(enumValue.ToString()).SingleOrDefault();

            if (memberInfo != null)
            {
                // Pobierz atrybut DescriptionAttribute (jeśli istnieje)
                var attribute = memberInfo.GetCustomAttributes(typeof(DescriptionAttribute), false).SingleOrDefault();
                if (attribute != null)
                {
                    // Zwróć wartość Description
                    return ((DescriptionAttribute)attribute).Description;
                }
            }
            // Jeśli brak atrybutu Description, zwróć nazwę enuma
            return enumValue.ToString();
        }
    }
}
