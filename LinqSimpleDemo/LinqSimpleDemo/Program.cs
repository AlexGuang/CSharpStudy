using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqSimpleDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            OddNumbers(numbers);
        }

        static void OddNumbers(int[] numbers)
        {
            Console.WriteLine("Odd Number:");
            IEnumerable<int> oddNumbers = from number in numbers where number % 2 == 1 select number;
            Console.WriteLine(oddNumbers);
            foreach (int oddNumber in oddNumbers)
            {
                Console.WriteLine(oddNumber);
            }
        }
    }
}
