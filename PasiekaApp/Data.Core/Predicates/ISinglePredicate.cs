using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.Predicates
{
    internal interface ISinglePredicate
    {
        bool Predicate(object realValue);
    }
}
