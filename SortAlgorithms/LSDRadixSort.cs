
using System;
using System.Collections.Generic;
using System.Linq;

namespace SortAlgorithms
{
    public class LSDRadixSort<T> : BaseAlgorithm<T>
        where T: IComparable
    {
        public LSDRadixSort() {}
        public LSDRadixSort(IEnumerable<T> items) : base(items){}
        public override void MakeSort()
        {
            var groups = new List<List<T>>();
            int i, temp, value, maxRadixSize;
            for (i = 0; i < 10; i++)
            {
                groups.Add(new List<T>());
            }
            maxRadixSize = Items.Max().ToString().Length;
            for (i = 0; i < maxRadixSize; i++)
            {
                // determine by buckets.
                foreach (var item in Items)
                {
                    temp = Int32.Parse(item.ToString());
                    value = temp % (int)Math.Pow(10, i + 1) / (int)Math.Pow(10, i);
                    groups[value].Add(item);
                }
                Items.Clear();
                // collect from buckets.
                foreach (var group in groups)
                {
                    foreach (var item in group)
                    {
                        Items.Add(item);
                    }
                }
                foreach (var group in groups)
                {
                    group.Clear();
                }
            }
        }
    }
}
