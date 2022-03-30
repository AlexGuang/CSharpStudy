using System;
using System.Collections.Generic;

namespace IEnumerableAsParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1,2,3,4,5,6,7,8 };


            int[] array = new int[] { 1, 2, 3,4, 5, 6, 7, 8 };

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);

            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);

            Console.WriteLine("Sum of list is {0}",GetSumOfIEnumerable(list));
            Console.WriteLine("Sum of array is {0}", GetSumOfIEnumerable(array));
            Console.WriteLine("Sum of queue is {0}",GetSumOfIEnumerable(queue));


        }
        public static int GetSumOfIEnumerable(IEnumerable<int> collection)
        {
            int sum = 0;
            foreach (int number in collection)
            {
                sum += number;
            }
            return sum;
        }
    }
}
