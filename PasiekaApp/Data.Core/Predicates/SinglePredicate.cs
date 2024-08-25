using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Predicates
{
    internal class SinglePredicate<T> : ISinglePredicate
    {
        private T _expectedValue;
        private Func<object, T> _valueGetter;
        private Func<T, T, bool> _predicate;
        public SinglePredicate(T expectedValue, Func<object, T> valueGetter, Func<T, T, bool> predicate)
        {
            _expectedValue = expectedValue;
            _valueGetter = valueGetter;
            _predicate = predicate;
        }
        public bool Predicate(object realValue)
        {
            return _predicate(_valueGetter(realValue), _expectedValue);
        }
    }
}
