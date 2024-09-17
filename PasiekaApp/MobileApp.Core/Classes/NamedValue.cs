using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Core.Classes
{
    public struct NamedValue<T>
    {
        public readonly T Value;
        public string Name { get; set; }
        public NamedValue(T enumValue, string name)
        {
            Value = enumValue;
            Name = name;
        }
    }
}
