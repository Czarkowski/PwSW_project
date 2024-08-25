using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Controls.CompositeControls
{
    public class IntegerEntry : Entry
    {
        public IntegerEntry()
        {
            Keyboard = Keyboard.Numeric;
            TextChanged += OnTextChanged;
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.NewTextValue) && !int.TryParse(e.NewTextValue, out _))
            {
                // Przywrócenie poprzedniej wartości, jeśli wprowadzona wartość nie jest liczbą całkowitą
                Text = e.OldTextValue;
            }
        }
    }
}
