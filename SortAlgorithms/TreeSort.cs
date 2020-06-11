using System;
using System.Collections.Generic;

namespace SortAlgorithms
{
    public class TreeSort<T> : BaseAlgorithm<T>
        where T: IComparable
    {
        public TreeSort() {}
        public TreeSort(IEnumerable<T> items) : base(items){}
        public override void MakeSort()
        {
			
            
		}
    }
}
