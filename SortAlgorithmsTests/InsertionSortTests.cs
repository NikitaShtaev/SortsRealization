using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortAlgorithmsTests;

namespace SortAlgorithms.Tests
{
    [TestClass()]
    public class InsertionSortTests
    {
        [TestMethod()]
        public void InsertionSortTest()
        {
            //arrange
            var helper = new HelperGetCollection();
            var dataList = helper.GetDataList();
            var result = helper.GetSortedItems(dataList);
            var insertion = new InsertionSort<int>(dataList);
            var count = insertion.Items.Count;
            //act
            insertion.Sort();
            //assert
            for (int i = 0; i < count; i++)
            {
                Assert.AreEqual(result[i], insertion.Items[i]);
            }
        }
    }
}