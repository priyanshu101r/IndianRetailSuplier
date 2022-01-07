using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndianRetailSuplier.Common.ExtensionMethods
{
    public static class EnumerableHelper
    {
        public static bool HasValue(this string str)
        {
            return !string.IsNullOrWhiteSpace(str);
        }
        //public static bool HasItems<T>(this IEnumerable<T> enumerable)
        //{
        //    return !enumerable.IsEnumerableNullOrEmpty();
        //}
    }
}
