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
            IEnumerable<TOutput> values = GetOfType<TOutput>(enumerable);

            return values;
        }



        public IEnumerable<TBase> OfBase<TBase, TDerived>(IEnumerable<TDerived> derivedItems) where TDerived : TBase
        {
            IEnumerable<TBase> values = GetOfType<TDerived, TBase>(derivedItems);

            return values;
        }

    }
}
