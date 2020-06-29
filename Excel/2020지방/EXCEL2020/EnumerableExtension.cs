using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCEL2020
{
    public static class EnumerableExtension
    {
        public static bool Empty<T>(this IEnumerable<T> source)
        {
            return !source.Any();
        }

        public static bool Empty<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            return !source.Any(predicate);
        }
    }
}
