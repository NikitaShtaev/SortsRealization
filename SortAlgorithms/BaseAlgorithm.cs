using System;
using System.Collections.Generic;

namespace SortAlgorithms
{
    public class BaseAlgorithm<T>
        where T: IComparable
    {
        public List<T> Items { get; set; } = new List<T>();
        private T Temp { get; set; }
        public int CompareCount { get; set; } = 0;
        public int SwapCount { get; set; } = 0;
        public string Time { get; set; }
        public BaseAlgorithm() { }
        public BaseAlgorithm(List<T> items)
        {
            Items = items;
        }
        public void Swap(int PosA, int PosB)
        {
            if (PosA < Items.Count && PosB < Items.Count)
            {
                Temp = Items[PosA];
                Items[PosA] = Items[PosB];
                Items[PosB] = Temp;
                SwapCount++;
            }
        }
        public bool GreaterCompare(int PosA, int PosB)
        {
            CompareCount++;
            return Items[PosA].CompareTo(Items[PosB]) == 1;
        }
        public bool SmallerCompare(int PosA, int PosB)
        {
            CompareCount++;
            return Items[PosA].CompareTo(Items[PosB]) == -1;
        }
        public virtual void Sort()
        {
            SwapCount = 0;
            CompareCount = 0;
            Items.Sort();
        }
    }
}
