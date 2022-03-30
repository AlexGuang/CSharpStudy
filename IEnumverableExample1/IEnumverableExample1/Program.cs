using System;
using System.Collections.Generic;

namespace IEnumverableExample1
{
    internal class Program
    {
        static void Main(string[] args)

        {    IEnumerable<int> newCollection;
            newCollection = GetIEnumerable(2);
        
            foreach (var item in GetIEnumerable(1))
            {
                Console.WriteLine(item);
            }
            foreach (var item in newCollection)
            {
                Console.WriteLine(item);
            }
        }
        public static IEnumerable<int> GetIEnumerable(int option)
        {
            List<int> list = new List<int>() { 1,2,3,4,5};
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);
            queue.Enqueue(10);
            int[]array = new int[]{ 11,12, 13, 14, 15};

            if (option ==1 )
            {
                return list;
            }
            else if (option ==2 )
            {
                return queue;
            }
            else
            {
                return array;
            }
        }
    }
}
