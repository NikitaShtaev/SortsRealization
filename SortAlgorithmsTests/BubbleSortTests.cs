using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortAlgorithms;
using System;
using System.Collections.Generic;

namespace SortAlgorithms.Tests
{
    [TestClass()]
    public class BubbleSortTests
    {

        public List<int> GetDataList()
        {
            var dataList = new List<int>();
            var rnd = new Random();
            for (int i = 0; i < 1000; i++)
            {
                dataList.Add(rnd.Next(0, 1000));
            }
            return dataList;
        }
        public List<int> GetSortedItems(List<int> Items)
        {
            var SortedItems = new List<int>();
            SortedItems.AddRange(Items);
            SortedItems.Sort();
            return SortedItems;
        }
        [TestMethod()]
        public void SortTest()
        {
            //arrange
            var dataList = GetDataList();
            var result = GetSortedItems(dataList);
            var bubble = new BubbleSort<int>(dataList);
            var count = bubble.Items.Count;
            //act
            bubble.Sort();
            //assert
            for (int i = 0; i < count; i++)
            {
                Assert.AreEqual(result[i], bubble.Items[i]);
            }
        }
    }
}