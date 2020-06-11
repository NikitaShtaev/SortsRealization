using System;
using System.Collections.Generic;

namespace SortAlgorithms
{
    public class QuickSort<T> : BaseAlgorithm<T>
        where T: IComparable
    {
        public QuickSort() {}
        public QuickSort(IEnumerable<T> items) : base(items){}
        public override void MakeSort()
        {
            QSort(0, Items.Count-1);
		} 
        private void QSort(int left, int right)
        {
            if (left >= right)
            {
                return;
            }
            var pivot = Sorting(left, right);
            QSort(left, pivot - 1);
            QSort(pivot + 1, right);
        }

        private int Sorting(int left, int right)
        {
            var pointer = left;
            int i;
            //Pivot is on right.
            for (i = left; i <= right; i++)
            {
                if(Compare(i, right) == -1)
                {
                    Swap(pointer, i);
                    pointer++;
                }
            }
            Swap(pointer, right);
            return pointer; 
        }
    }
}
