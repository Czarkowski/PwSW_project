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
    public BindingBase KeyBinding { get; set; }

    public object ProvideValue(IServiceProvider serviceProvider)
    {
        if (KeyBinding != null)
        {
            var provideValueTarget = serviceProvider.GetService(typeof(IProvideValueTarget)) as IProvideValueTarget;
            var bindableObject = provideValueTarget?.TargetObject as BindableObject;
            if (bindableObject != null)
            {
                bindableObject.SetBinding(BindableProperty.Create(nameof(Key), typeof(string), typeof(string)), KeyBinding);
                Key = bindableObject.GetValue(BindableProperty.Create(nameof(Key), typeof(string), typeof(string))) as string;
            }
        }
        return Key != null ? LocalizeManager.Translate(Key) : string.Empty;
    }

    //public static readonly BindableProperty BindingProperty =
    //    BindableProperty.CreateAttached(nameof(KeyBinding), typeof(object), typeof(TranslateExtension), null);
}