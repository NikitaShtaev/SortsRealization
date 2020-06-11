
using System;
using System.Collections.Generic;

namespace SortAlgorithms
{
    public class SelectionSort<T> : BaseAlgorithm<T>
        where T: IComparable
    {
        public SelectionSort() {}
        public SelectionSort(IEnumerable<T> items) : base(items){}
        public override void MakeSort()
        {
            var count = Items.Count;
            int minIndex;
            int i, j;
            for (i = 0; i < count-1; i++)
            {
                minIndex = i;
                for (j = i + 1; j < count; j++)
                {
                    if (Compare(j, minIndex) == -1)
                    {
                        minIndex = j;
                    }
                }
                if (i != minIndex)
                {
                    Swap(i, minIndex);
                }
            }
        }
    }
}
