using SortAlgorithms.DataStructures;
using System;
using System.Collections.Generic;

namespace SortAlgorithms
{
    public class TreeSort<T> : BaseAlgorithm<T>
        where T: IComparable, IComparable<T>
    {
        public TreeSort() {}
        public TreeSort(IEnumerable<T> items, string name) : base(items, name){}
        public override void MakeSort()
        {
            BinaryTree<T> binaryTree = new BinaryTree<T>(Items);
            Items = binaryTree.Inorder();
        }
    }
}
