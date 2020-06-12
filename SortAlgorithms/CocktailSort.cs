using System;
using System.Collections.Generic;

namespace SortAlgorithms
{
    public class CocktailSort<T>: BaseAlgorithm<T>
        where T: IComparable
    {
        public CocktailSort() {}
        public CocktailSort(IEnumerable<T> items, string name) : base(items, name) { }
        public override void MakeSort()
        {
            int i, sc;
            int left = 0;
            int right = Items.Count - 1;
            while(left<right)
            {
                sc = SwapCount;
                for (i = left; i < right; i++)
                {
                    if (Compare(i, i + 1) == 1)
                    {
                        Swap(i, i + 1);
                    }
                }
                right--;
                if (sc == SwapCount)
                {
                    break;
                }
                for (i = right; i > left; i--)
                {
                    if (Compare(i, i-1) == -1)
                    {
                        Swap(i, i - 1);
                    }
                }
                left++;
                if (sc == SwapCount)
                {
                    break;
                }
            }
        }
    }
}
