using System;
using Sort;

namespace TheBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 5, 45, 23, 56, 1, 7, 12, 45, 50, 0, 31, 29, 61, 78, 3, 18, 8, 41, 4 };

            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.Sort(ref array);

            foreach (int item in array)
            {
                Console.Write("{0}, ", item);
            }
        }
    }
}
