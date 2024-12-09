using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Predicates;

public class SqlPredicate<T> where T : class
{
    private List<Tuple<ISinglePredicate, ConcatType>> _predicates = new List<Tuple<ISinglePredicate, ConcatType>>();

    public void AddPredicate<L>(L expectedValue, Func<T, L> valueGetter, Func<L, L, bool> predicate, ConcatType predicateConcat) 
    {
        _predicates.Add(new Tuple<ISinglePredicate, ConcatType>(new SinglePredicate<L>(expectedValue, (x) => valueGetter(x as T), predicate), predicateConcat));
    }

    public bool Predicate(T realValue)
    {
        List<ISinglePredicate> orPredicates = _predicates.FindAll(x => x.Item2 == ConcatType.Or).Select(x => x.Item1).ToList();
        List<ISinglePredicate> andPredicates = _predicates.FindAll(x => x.Item2 == ConcatType.And).Select(x => x.Item1).ToList();
        return andPredicates.All(x => x.Predicate(realValue))
            && ((orPredicates.Count > 0) ? orPredicates.Any(x => x.Predicate(realValue)) : true);
    }

}
