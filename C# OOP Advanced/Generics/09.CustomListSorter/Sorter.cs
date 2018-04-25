using System;
using System.Linq;

namespace _09.CustomListSorter
{
    public class Sorter
    {
        public static CustomList<T> Sort<T>(CustomList<T> customList)
            where T : IComparable<T>
        {
            var sorted = customList.Elements.OrderBy(x => x).ToList();
                return new CustomList<T>(sorted);
        }
    }
}
