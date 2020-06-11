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
            for (int i = 0; i < 1000; i++)
            {
                dataList.Add(rnd.Next(0, 1000));
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
    }
}