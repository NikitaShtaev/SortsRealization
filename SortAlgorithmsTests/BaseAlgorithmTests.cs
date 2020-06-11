using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortAlgorithmsTests;

namespace SortAlgorithms.Tests
{
    [TestClass()]
    public class BaseAlgorithmTests
    {
        [TestMethod()]
        public void SortTest()
        {
            //arrange
            var helper = new HelperGetCollection();
            var dataList = helper.GetDataList();
            var result = helper.GetSortedItems(dataList);
            var baseSort = new BaseAlgorithm<int>(dataList);
            var count = baseSort.Items.Count;
            //act
            baseSort.Sort();
            //assert
            for (int i = 0; i < count; i++)
            {
                Assert.AreEqual(result[i], baseSort.Items[i]);
            }
        }
    }
}