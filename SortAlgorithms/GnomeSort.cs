
using System;
using System.Collections.Generic;

namespace SortAlgorithms
{
    public class GnomeSort<T> : BaseAlgorithm<T>
        where T: IComparable
    {
        public GnomeSort() {}
        public GnomeSort(IEnumerable<T> items) : base(items){}
        public override void MakeSort()
        {
            var count = Items.Count;
            int i = 1;
            int j = 2;
            while (i < count)
            {
                if (Compare(i - 1, i) == -1)
                {
                    i = j;
                    j++;
                }
                else
                {
                    Swap(i - 1, i);
                    i--;
                    if (i == 0)
                    {
                        i = j;
                        j++;
                    }
                }
            }
        }
    }
}
