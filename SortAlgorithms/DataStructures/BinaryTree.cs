
using System;
using System.Collections.Generic;

namespace SortAlgorithms.DataStructures
{
    public class BinaryTree<T>
        where T : IComparable, IComparable<T>
    {
        /// <summary>
        /// Root element.
        /// </summary>
        public Node<T> Root { get; private set; }
        /// <summary>
        /// Quantity of elements.
        /// </summary>
        public int Count { get; private set; }
        public BinaryTree(){ }
        public BinaryTree(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Add(item);
            }
        }
        /// <summary>
        /// Adding of element.
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            if (Root == null)
            {
                Root = new Node<T>(data);
                Count = 1;
                return;
            }
            Root.Add(data);
            Count++;
        }
        /// <summary>
        /// Going within elements by inordering.
        /// </summary>
        /// <returns></returns>
        public List<T> Inorder()
        {
            if (Root == null)
            {
                return new List<T>();
            }
            return Inorder(Root);
        }
        /// <summary>
        /// Helper for going within elements by inordering.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private List<T> Inorder(Node<T> node)
        {
            var lst = new List<T>();
            if (node != null)
            {
                if (node.Left != null)
                {
                    lst.AddRange(Inorder(node.Left));
                }
                lst.Add(node.Data);
                if (node.Right != null)
                {
                    lst.AddRange(Inorder(node.Right));
                }
            }
            return lst;
        } 
    }
}
