using System;
using System.Collections.Generic;
using System.Linq;

namespace BubbleSort
{
    class Program
    {
        public static object StringPermutation { get; private set; }

        static void Main(string[] args)
        {
            var randomNumbers = new int[] { 5, 4, 5, 7, 6, 9, 4, 1, 1, 3, 4, 50, 56, 41 };
            var sortedNumbers = BubbleSort(randomNumbers);
            PrintList(sortedNumbers);
            Console.ReadKey();
        }

        private static IEnumerable<T> BubbleSort<T>(IEnumerable<T> list) where T : IComparable
        {
            T[] sortedList = list.ToArray();
            int listLength = sortedList.Length;
            while (true)
            {
                bool performedSwap = false;
                for (int currentItemIndex = 1; currentItemIndex < listLength; currentItemIndex++)
                {
                    int previousItemIndex = currentItemIndex - 1;
                    T previousItem = sortedList[previousItemIndex];
                    T currentItem = sortedList[currentItemIndex];
                    var comparison = previousItem.CompareTo(currentItem);
                    if (comparison > 0)
                    {
                        sortedList[previousItemIndex] = currentItem;
                        sortedList[currentItemIndex] = previousItem;
                        performedSwap = true;
                    }
                }

                if (!performedSwap)
                {
                    break;
                }
            }

            return sortedList;
        }

        private static void PrintList<T>(IEnumerable<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}