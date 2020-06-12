using System;
using System.Collections.Generic;

namespace SortAlgorithms
{
    public class ShellSort<T> : BaseAlgorithm<T>
        where T: IComparable
    {
        public ShellSort() {}
        public ShellSort(IEnumerable<T> items, string name) : base(items, name){}
        public override void MakeSort()
        {
			int step, i, j;
			var count = Items.Count;
			// Выбор шага
			for (step = count / 2; step > 0; step /= 2)
				// Перечисление элементов, которые сортируются на определённом шаге
				for (i = step; i < count; i++)
					// Перестановка элементов внутри подсписка, пока i-тый не будет отсортирован
					for (j = i - step; j >= 0 && Compare(j, j + step) == 1; j -= step)
					{
						Swap(j, j + step);
					}
		}
    }
}
