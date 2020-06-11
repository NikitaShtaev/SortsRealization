using System;
using System.Collections.Generic;

namespace SortAlgorithms
{
    public class InsertionSort<T>: BaseAlgorithm<T>
        where T: IComparable
    {
        public InsertionSort() {}
        public InsertionSort(List<T> items) : base(items) { }
        public override void MakeSort()
        {
            var count = Items.Count;
            int i, j;
            T temp;
            for (i = 1; i < count; i++)
            {
                temp = Items[i];
                j = i;
                while (j > 0 && Compare(temp, Items[j - 1]) == -1)
                {
                    Items[j] = Items[j - 1];
                    SwapCount++;
                    j--;
                }
                Items[j] = temp;
            }
        }
    }
}
