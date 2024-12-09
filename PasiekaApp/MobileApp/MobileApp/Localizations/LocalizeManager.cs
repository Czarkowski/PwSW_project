using Microsoft.Extensions.Localization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Localizations;

public static class LocalizeManager
{
    //private static IStringLocalizer _localizer;

    private static ResourceManager _resourceManager;
    private static CultureInfo _currentCulture;

    //static LocalizeManager()
    //{
    //    // Inicjalizacja ResourceManager z domyślną kulturą
    //    _resourceManager = new ResourceManager("MobileApp.Resources.Languages.Strings", typeof(App).Assembly);
    //}

    public static string Translate(string key)
    {
        return _resourceManager?.GetString(key, _currentCulture) ?? key;
    }

    public static void SetCulture(CultureInfo culture)
    {
        _currentCulture = culture;
    }

    public static void Initialize(ResourceManager resourceManager)
    {
        _resourceManager = resourceManager;
    }

    public static string TranslateWithFormat(string key, params string[] strings)
    {
        string value = _resourceManager?.GetString(key, _currentCulture);
        return value != null 
            ? string.Format(value, strings)
            : $"{key}:{string.Join(";", strings)}";
    }
}
