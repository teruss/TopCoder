using System.Collections.Generic;

namespace System.Linq
{
    public static class UniEnumerable
    {
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this IEnumerable<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector)
        {
            Check.FirstAndSecond(first, second);
            if (resultSelector == null)
                throw new ArgumentNullException("resultSelector");
    
            return CreateZipIterator(first, second, resultSelector);
        }

        static IEnumerable<TResult> CreateZipIterator<TFirst, TSecond, TResult>(IEnumerable<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> selector)
        {
            using (IEnumerator<TFirst> first_enumerator = first.GetEnumerator ())
            {
                using (IEnumerator<TSecond> second_enumerator = second.GetEnumerator ())
                {
            
                    while (first_enumerator.MoveNext () && second_enumerator.MoveNext ())
                    {
                        yield return selector(first_enumerator.Current, second_enumerator.Current);
                    }
                }
            }
        }
    }
}