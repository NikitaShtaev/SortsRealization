using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace SortAlgorithms.Tests
{
    [TestClass()]
    public class SortTests
    {
        List<int> dataList = new List<int>();
        List<int> sortedItems = new List<int>();
        Random rnd = new Random();
        int count;
        [TestInitialize]
        public void Init()
        {
            dataList.Clear();
            for (int i = 0; i < 10000; i++)
            {
                dataList.Add(rnd.Next(0, 10000000));
            }
            sortedItems.Clear();
            sortedItems.AddRange(dataList);
            sortedItems.Sort();
            count = dataList.Count;
        }

        [TestMethod()]
        public void BaseSortTest()
        {
            //arrange
            var baseSort = new BaseAlgorithm<int>(dataList);
            //act
            baseSort.Sort();
            //assert
            for (int i = 0; i < count; i++)
            {
                Assert.AreEqual(sortedItems[i], baseSort.Items[i]);
            }
        }
        [TestMethod()]
        public void BubbleSortTest()
        {
            //arrange
            var bubbleSort = new BubbleSort<int>(dataList);
            //act
            bubbleSort.Sort();
            //assert
            for (int i = 0; i < count; i++)
            {
                Assert.AreEqual(sortedItems[i], bubbleSort.Items[i]);
            }
        }
        [TestMethod()]
        public void CocktailSortTest()
        {
            //arrange
            var cocktailSort = new CocktailSort<int>(dataList);
            //act
            cocktailSort.Sort();
            //assert
            for (int i = 0; i < count; i++)
            {
                Assert.AreEqual(sortedItems[i], cocktailSort.Items[i]);
            }
        }
        [TestMethod()]
        public void InsertionSortTest()
        {
            //arrange
            var insertionSort = new InsertionSort<int>(dataList);
            //act
            insertionSort.Sort();
            //assert
            for (int i = 0; i < count; i++)
            {
                Assert.AreEqual(sortedItems[i], insertionSort.Items[i]);
            }
        }
        [TestMethod()]
        public void ShellSortTest()
        {
            //arrange
            var ShellSort = new ShellSort<int>(dataList);
            //act
            ShellSort.Sort();
            //assert
            for (int i = 0; i < count; i++)
            {
                Assert.AreEqual(sortedItems[i], ShellSort.Items[i]);
            }
        }
        [TestMethod()]
        public void TreeSortTest()
        {
            //arrange
            var TreeSort = new TreeSort<int>(dataList);
            //act
            TreeSort.Sort();
            //assert
            for (int i = 0; i < count; i++)
            {
                Assert.AreEqual(sortedItems[i], TreeSort.Items[i]);
            }
        }
        [TestMethod()]
        public void HeapSortTest()
        {
            //arrange
            var HeapSort = new HeapSort<int>(dataList);
            //act
            HeapSort.Sort();
            //assert
            for (int i = 0; i < count; i++)
            {
                Assert.AreEqual(sortedItems[i], HeapSort.Items[i]);
            }
        }
        [TestMethod()]
        public void SelectionSortTest()
        {
            //arrange
            var selection = new SelectionSort<int>(dataList);
            //act
            selection.Sort();
            //assert
            for (int i = 0; i < count; i++)
            {
                Assert.AreEqual(sortedItems[i], selection.Items[i]);
            }
        }
        [TestMethod()]
        public void GnomeSortTest()
        {
            //arrange
            var gnome = new GnomeSort<int>(dataList);
            //act
            gnome.Sort();
            //assert
            for (int i = 0; i < count; i++)
            {
                Assert.AreEqual(sortedItems[i], gnome.Items[i]);
            }
        }
        [TestMethod()]
        public void LSDRadixSortTest()
        {
            //arrange
            var LSDradix = new LSDRadixSort<int>(dataList);
            //act
            LSDradix.Sort();
            //assert
            for (int i = 0; i < count; i++)
            {
                Assert.AreEqual(sortedItems[i], LSDradix.Items[i]);
            }
        }
        [TestMethod()]
        public void MSDRadixSortTest()
        {
            //arrange
            var MSDradix = new MSDRadixSort<int>(dataList);
            //act
            MSDradix.Sort();
            //assert
            for (int i = 0; i < count; i++)
            {
                Assert.AreEqual(sortedItems[i], MSDradix.Items[i]);
            }
        }
        [TestMethod()]
        public void MergeSortTest()
        {
            //arrange
            var merge = new MergeSort<int>(dataList);
            //act
            merge.Sort();
            //assert
            for (int i = 0; i < count; i++)
            {
                Assert.AreEqual(sortedItems[i], merge.Items[i]);
            }
        }
        [TestMethod()]
        public void QuickSortTest()
        {
            //arrange
            var quick = new QuickSort<int>(dataList);
            //act
            quick.Sort();
            //assert
            for (int i = 0; i < count; i++)
            {
                Assert.AreEqual(sortedItems[i], quick.Items[i]);
            }
        }
    }
}