using System;
using System.Collections.Generic;
using System.Linq;

namespace SortAlgorithms
{
    public class MergeSort<T> : BaseAlgorithm<T>
        where T: IComparable
    {
        public MergeSort() {}
        public MergeSort(IEnumerable<T> items, string name) : base(items, name){}
        public override void MakeSort()
        {
            Items = SortMerge(Items);
		}
        private List<T> SortMerge(List<T> items)
        {
            if(items.Count == 1)
            {
                return items;
            }
            var mid = items.Count / 2;
            var left = items.Take(mid).ToList();
            var rigth = items.Skip(mid).ToList();
            return Merge(SortMerge(left), SortMerge(rigth));
        }

        private List<T> Merge(List<T> left, List<T> right)
        {
            var length = left.Count + right.Count;
            var leftPointer = 0;
            var rightPointer = 0;
            int i;
            var result = new List<T>();
            for (i = 0; i < length; i++)
            {
                if (leftPointer < left.Count && rightPointer < right.Count)
                {
                    if (Compare(left[leftPointer], right[rightPointer]) == -1)
                    {
                        result.Add(left[leftPointer]);
                        leftPointer++;
                    }
                    else
                    {
                        result.Add(right[rightPointer]);
                        rightPointer++;
                    }
                }
                else
                {
                    if (rightPointer < right.Count)
                    {
                        result.Add(right[rightPointer]);
                        rightPointer++;
                    }
                    else
                    {
                        result.Add(left[leftPointer]);
                        leftPointer++;
                    }
                }
            }
            return result;
        }
    }
}
