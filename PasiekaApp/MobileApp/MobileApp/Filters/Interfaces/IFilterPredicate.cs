using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Filters.Interfaces
{
    public interface IFilterPredicate<T>
    {
        bool Predicate(T value);
    }
}
