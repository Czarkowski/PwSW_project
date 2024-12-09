using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Localizations;

[ContentProperty(nameof(Key))] 
public class TranslateExtension : IMarkupExtension
{
    public string Key { get; set; }

    public object ProvideValue(IServiceProvider serviceProvider)
    {
        if (Key == null)
            return string.Empty;

        return LocalizeManager.Translate(Key);
    }
}
