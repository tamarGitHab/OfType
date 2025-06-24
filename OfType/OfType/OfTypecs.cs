using System.Collections;


namespace OfType
{
    internal class OfTypecs : IOfType
    {
        public IEnumerable<T> GetOfType<T>(IEnumerable enumerable)
        {
            List<T> values = new List<T>();
            foreach (var item in enumerable) {
                if (item is T Titem) { 
                    values.Add(Titem);
                }
            }

            return values;
        }

        public IEnumerable<TOutput> GetOfType<TSource, TOutput>(IEnumerable<TSource> enumerable)
        {
            List<TOutput> values = new List<TOutput>();
            foreach (var item in enumerable)
            {
                if (item is TOutput Titem)
                {
                    values.Add(Titem);
                }
            }

            return values;
        }

        public IEnumerable<TBase> OfBase<TBase, TDerived>(IEnumerable<TDerived> derivedItems) where TDerived : TBase
        {
            List<TBase> values = new List<TBase>();
            foreach (var item in derivedItems)
            {
                if (item is TBase Titem)
                {
                    values.Add(Titem);
                }
            }

            return values;
        }
    }
}
