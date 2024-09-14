using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.UserPreferences
{
    public static class AppPreferences
    {
        public static readonly string DefaultLanguage = "pl";
        public static string Language
        {
            get => Preferences.Get(PreferencesKeys.Launguage, DefaultLanguage);
            set => Preferences.Set(PreferencesKeys.Launguage, value);
        }
    }
}
