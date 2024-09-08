using Data.Core.Predicates;
using MobileApp.Filters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Filters
{
    public class FilterPredicate<T> : SqlPredicate<T>, IFilterPredicate<T> where T : class
    {
    }
}
