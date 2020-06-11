using System;
using System.Collections.Generic;

namespace SortAlgorithmsTests
{
    public class HelperGetCollection
    {
        /// <summary>
        /// Returns list with random values.
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Returns sorted list in correct way.
        /// </summary>
        /// <param name="Items"></param>
        /// <returns></returns>
        public List<int> GetSortedItems(List<int> Items)
        {
            var SortedItems = new List<int>();
            SortedItems.AddRange(Items);
            SortedItems.Sort();
            return SortedItems;
        }
    }
}
