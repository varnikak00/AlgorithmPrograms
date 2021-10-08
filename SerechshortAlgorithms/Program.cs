using System;
using System.Collections.Generic;
using System.Linq;

namespace SerechshortAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomNumbers = new int[] { 5, 4, 5, 7, 6, 9, 4, 1, 1, 3, 4, 50, 56, 41 };

            var sortedNumbers = InsertionSort(randomNumbers);
            Console.WriteLine("sorting:");
            PrintList(sortedNumbers);
            Console.ReadKey();
        }

        private static IEnumerable<T> InsertionSort<T>(IEnumerable<T> list) where T : IComparable
        {
            T[] sortedList = list.ToArray();
            int listLength = sortedList.Length;
            for (int i = 1; i < listLength; i++)
            {
                for (int previousItemIndex = i - 1; previousItemIndex > -1; previousItemIndex--)
                {
                    int currentItemIndex = previousItemIndex + 1;
                    T currentItem = sortedList[currentItemIndex];
                    T previousItem = sortedList[previousItemIndex];
                    var comparison = previousItem.CompareTo(currentItem);
                    if (comparison > 0)
                    {
                        sortedList[previousItemIndex] = currentItem;
                        sortedList[currentItemIndex] = previousItem;
                    }
                    else
                    {
                        break;
                    }
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

