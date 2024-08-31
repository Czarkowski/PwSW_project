using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.StaticExtensions;

namespace MobileApp.Core.Behaviors
{
    public class DoubleValidationBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += OnTextChanged;
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.TextChanged -= OnTextChanged;
            base.OnDetachingFrom(bindable);
        }

        void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue.IsNEoWS())
            {
                ((Entry)sender).Text = ((double)default).ToString();
            }
            else if (!double.TryParse(e.NewTextValue, out _))
            {
                ((Entry)sender).Text = e.OldTextValue;
            }
        }
    }
}
