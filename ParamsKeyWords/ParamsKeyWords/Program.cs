using System;

namespace ParamsKeyWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vs = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, -500 };
            Console.WriteLine("The minimum value is :{0}", GetMinValue(vs));
            int min = GetMinValue(4, 4, 2, 1, 0, -1, 100);
            Console.WriteLine(min);
        }
        public static int GetMinValue(params int[] numbers)
        {
            int min = int.MaxValue;
            foreach (int  item in numbers)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }
    }
}
