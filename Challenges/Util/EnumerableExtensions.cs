using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenges.Util
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<TResult> ZipThree<T1, T2, T3, TResult>(this IEnumerable<T1> list1,
            IEnumerable<T2> list2, IEnumerable<T3> list3, Func<T1, T2, T3, TResult> func)
        {
            using (var e1 = list1.GetEnumerator())
            using (var e2 = list2.GetEnumerator())
            using (var e3 = list3.GetEnumerator())
            {
                while (e1.MoveNext() && e2.MoveNext() && e3.MoveNext())
                    yield return func(e1.Current, e2.Current, e3.Current);
            }
        }

        public static IEnumerable<IEnumerable<T>> Transpose<T>(this IEnumerable<IEnumerable<T>> l)
        {
            return l.SelectMany(inner => inner.Select((item, index) => new { item, index }))
                .GroupBy(i => i.index, i => i.item)
                .Select(g => g.ToList());
        }
    }
}
