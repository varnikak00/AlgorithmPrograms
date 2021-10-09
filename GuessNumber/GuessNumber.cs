using System;
using System.Collections.Generic;
using System.Text;

namespace GuessNumber
{
    class GuessNumber
    {
        static bool isFound = false;
        static int start = 1;
        static int end = 100;
        public static int FindMin()
        {
            int mid = (start + end) / 2;
            return mid;

        }
        public static void UserInput(int midNum)
        {
            Console.WriteLine("1->Is your number {0} \n2->Is your number less than {0} \n3->Is your number Greater than {0}", midNum);
            Console.WriteLine("Enter your choice");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine(" Guessed Number is found " + midNum);
                    isFound = true;
                    break;
                case 2:
                    end = midNum - 1;
                    break;
                case 3:
                    start = midNum + 1;
                    break;
                default:
                    Console.WriteLine("Enter the valid option!!");
                    break;
            }
        }
        public static void ThinkNumber()
        {
            Console.WriteLine("Assume a number between {0} - {1} ", start, end);
            while (start != end && isFound == false)
            {
                int midVal = FindMin();
                UserInput(midVal);
            }
            if (start == end)
            {
                Console.WriteLine("Guessing number is {0} ", end);
            }
        }
    }
}
   