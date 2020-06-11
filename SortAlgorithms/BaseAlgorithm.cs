using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SortAlgorithms
{
    public class BaseAlgorithm<T>
        where T: IComparable
    {
        /// <summary>
        /// Collection of values.
        /// </summary>
        public List<T> Items { get; set; } = new List<T>();
        /// <summary>
        /// Value for swap.
        /// </summary>
        private T Temp { get; set; }
        /// <summary>
        /// Count of compare operation.
        /// </summary>
        public int CompareCount { get; set; } = 0;
        /// <summary>
        /// Count of swap operation.
        /// </summary>
        public int SwapCount { get; set; } = 0;
        /// <summary>
        /// Time that sort operation takes.
        /// </summary>
        public string Time { get; set; }
        /// <summary>
        /// Constructor without parameters.
        /// </summary>
        public BaseAlgorithm() { }
        /// <summary>
        /// Constructor that takes List of values.
        /// </summary>
        /// <param name="items"></param>
        public BaseAlgorithm(List<T> items)
        {
            Items = items;
        }
        /// <summary>
        /// Swap operation changes items in collection by numbers.
        /// </summary>
        /// <param name="PosA"></param>
        /// <param name="PosB"></param>
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
        /// <summary>
        /// Returns comparing int value for two items in indexes.
        /// </summary>
        /// <param name="PosA"></param>
        /// <param name="PosB"></param>
        /// <returns></returns>
        public int Compare(int PosA, int PosB)
        {
            CompareCount++;
            return Items[PosA].CompareTo(Items[PosB]);
        }
        public void Swap(T item1, T item2)
        {
            Temp = item1;
            item1 = item2;
            item2 = Temp;
            SwapCount++;
        }
        public int Compare(T item1, T item2)
        {
            CompareCount++;
            return item1.CompareTo(item2);
        }
        /// <summary>
        /// Arranges sort procedure.
        /// </summary>
        public void Sort()
        {
            SwapCount = 0;
            CompareCount = 0;
            var timer = new Stopwatch();
            timer.Start();
            MakeSort();
            Time = timer.Elapsed.ToString();
            timer.Stop();
        }
        /// <summary>
        /// Base algorithm for sort.
        /// </summary>
        public virtual void MakeSort()
        {
            Items.Sort();
        }
    }
}
