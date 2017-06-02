using System;
using System.Collections.Generic;
using System.Text;


namespace differed_linq
{
    public static class MyLinq
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, Predicate<T> f)
        {
            List<T> result = new List<T>();

            foreach (var item in source)
            {
                if (f(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public static IEnumerable<T> DifferedFilter<T>(this IEnumerable<T> source, Predicate<T> f)
        {
            List<T> result = new List<T>();

            foreach (var item in source)
            {
                if (f(item))
                {
                    yield return item;
                }
            }
        }
    }
}
