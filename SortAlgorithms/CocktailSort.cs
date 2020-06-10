using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SortAlgorithms
{
    public class CocktailSort<T>: BaseAlgorithm<T>
        where T: IComparable
    {
        public CocktailSort() {}
        public CocktailSort(List<T> items) : base(items) { }
        public override void Sort()
        {
            SwapCount = 0;
            CompareCount = 0;
            var timer = new Stopwatch();
            timer.Start();
            int sc;
            int left = 0;
            int right = Items.Count - 1;
            while(left<right)
            {
                sc = SwapCount;
                for (int i = left; i < right; i++)
                {
                    if (GreaterCompare(i, i + 1))
                    {
                        Swap(i, i + 1);
                    }
                }
                right--;
                if (sc == SwapCount)
                {
                    break;
                }
                for (int i = right; i > left; i--)
                {
                    if (SmallerCompare(i, i-1))
                    {
                        Swap(i, i-1);
                    }
                }
                left++;
                if (sc == SwapCount)
                {
                    break;
                }
            }
            Time = timer.Elapsed.ToString();
            timer.Stop();
        }
    }
}
