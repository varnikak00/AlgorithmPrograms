using System;

namespace bupple_sort1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] intArray = new int[5];
            Console.WriteLine("Enter the Array Elements : ");
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }
            bool flag = true;
            for (int i = 1; (i <= (intArray.Length - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (intArray.Length - 1); j++)
                {
                    count = count + 1;
                    if (intArray[j + 1] > intArray[j])
                    {
                        int temp = intArray[j];
                        intArray[j] = intArray[j + 1];
                        intArray[j + 1] = temp;
                        flag = true;
                    }
                }
            }
            Console.WriteLine("After Sorting Array :");
            foreach (int item in intArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("The Loop iterates :" + count);
            Console.ReadKey();
        }
    }
}
