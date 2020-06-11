﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortAlgorithmsTests;

namespace SortAlgorithms.Tests
{
    [TestClass()]
    public class CocktailSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            //arrange
            var helper = new HelperGetCollection();
            var dataList = helper.GetDataList();
            var result = helper.GetSortedItems(dataList);
            var Cocktail = new CocktailSort<int>(dataList);
            var count = Cocktail.Items.Count;
            //act
            Cocktail.Sort();
            //assert
            for (int i = 0; i < count; i++)
            {
                Assert.AreEqual(result[i], Cocktail.Items[i]);
            }
        }
    }
}