
using System;
using System.Collections.Generic;

namespace SortAlgorithms
{
    public class BubbleSort<T> : BaseAlgorithm<T>
        where T: IComparable
    {
        public BubbleSort() {}
        public BubbleSort(List<T> items) : base(items){}
        public override void MakeSort()
        {
            var count = Items.Count;
            int i, j;
            for (i = 0; i < count; i++)
            {
                for (j = 0; j < count - i-1; j++)
                {
                    if (Compare(j, j + 1) == 1)
                    {
                        Swap(j, j + 1);
                    }
                }
            }
        }
    }
}
