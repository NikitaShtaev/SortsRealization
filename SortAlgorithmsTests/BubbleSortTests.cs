using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortAlgorithmsTests;


namespace SortAlgorithms.Tests
{
    [TestClass()]
    public class BubbleSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            //arrange
            var helper = new HelperGetCollection();
            var dataList = helper.GetDataList();
            var result = helper.GetSortedItems(dataList);
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