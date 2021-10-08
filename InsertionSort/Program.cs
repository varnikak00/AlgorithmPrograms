using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Insertion Sort");
            string[] a = { "sabi", "pavi", "hannah", "priya", "varni" };
            string temp;
            int j;

            for (int i = 1; i <= a.Length - 1; i++)
            {
                temp = a[i];
                j = i;
                while (j > 0 && a[j - 1].CompareTo(temp) > 0)
                {
                    a[j] = a[j - 1];
                    j = j - 1;
                }
                a[j] = temp;
            }
            for (int i = 0; i <= a.Length - 1; i++)
            {
                Console.Write(a[i] + " ");

            }
            Console.WriteLine();
            Console.WriteLine("---------------");
        }
    }
}

        