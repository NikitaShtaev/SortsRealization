using SortAlgorithms.DataStructures;
using System;
using System.Collections.Generic;

namespace SortAlgorithms
{
    public class HeapSort<T> : BaseAlgorithm<T>
        where T: IComparable, IComparable<T>
    {
        public HeapSort() {}
        public HeapSort(IEnumerable<T> items, string name) : base(items, name){}
        public override void MakeSort()
        {
            Heap<T> heap = new Heap<T>(Items);
            Items = heap.Order();
        }
    }
}
