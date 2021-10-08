using System;
using System.Collections.Generic;

namespace BubbleSort
{
    internal class BinarySearch<T>
    {
        private string[] arr;
        private string word;

        public BinarySearch(string[] arr, string word)
        {
            this.arr = arr;
            this.word = word;
        }

        internal void PrintArry(List<int> arr)
        {
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        internal void Search(int v, List<int> arr)
        {
            for (int i = 0; i < arr.Count - 1; i++)
            {
                for (int j = 0; j < arr.Count - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("After sorting");
            PrintArry(arr);
        }

        internal void Search(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }

}