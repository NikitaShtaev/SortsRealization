
using System;
using System.Collections.Generic;
using System.Linq;

namespace SortAlgorithms
{
    public class MSDRadixSort<T> : BaseAlgorithm<T>
        where T: IComparable
    {
        public MSDRadixSort() {}
        public MSDRadixSort(IEnumerable<T> items) : base(items){}
        public override void MakeSort()
        {
            int maxRadixSize = Items.Max().ToString().Length;
            Items = SortCollection(Items, maxRadixSize-1);
        }
        private List<T> SortCollection(List<T> collection, int step)
        {
            var result = new List<T>();
            var groups = new List<List<T>>();
            int i, temp, value;
            for (i = 0; i < 10; i++)
            {
                groups.Add(new List<T>());
            }
            // determine by buckets.
            foreach (var item in collection)
            {
                temp = Int32.Parse(item.ToString());
                value = temp % (int)Math.Pow(10, step + 1) / (int)Math.Pow(10, step);
                groups[value].Add(item);
            }
            // collect from buckets.
            foreach (var group in groups)
            {
                if (group.Count > 1 && step > 0)
                {
                    result.AddRange(SortCollection(group, step - 1));
                    continue;
                }
                result.AddRange(group);
            }
            return result;    
        }
    }
}
