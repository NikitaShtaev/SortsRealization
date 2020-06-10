
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SortAlgorithms
{
    public class BubbleSort<T> : BaseAlgorithm<T>
        where T: IComparable
    {
        public BubbleSort() {}
        public BubbleSort(List<T> items) : base(items){}
        public override void Sort()
        {
            SwapCount = 0;
            CompareCount = 0;
            var timer = new Stopwatch();
            timer.Start();
            var count = Items.Count;
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count - i-1; j++)
                {
                    if (GreaterCompare(j,j+1))
                    {
                        Swap(j, j + 1);
                    }
                }
            }
            Time = timer.Elapsed.ToString();
            timer.Stop();
        }
    }
}
