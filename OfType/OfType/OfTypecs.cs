using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfType
{
    internal class OfTypecs : IOfType
    {
        public IEnumerable<T> GetOfType<T>(IEnumerable enumerable)
        {
            IEnumerable<T> values = enumerable.OfType<T>();
            return values;
        }

        public IEnumerable<TOutput> GetOfType<TSource, TOutput>(IEnumerable<TSource> enumerable)
        {
            IEnumerable<TOutput> values = enumerable.OfType<TOutput>();
            return values;
        }

        public IEnumerable<TBase> OfBase<TBase, TDerived>(IEnumerable<TDerived> derivedItems) where TDerived : TBase
        {
            IEnumerable<TBase> values = derivedItems.OfType<TBase>();
            return values;
        }
    }
}
