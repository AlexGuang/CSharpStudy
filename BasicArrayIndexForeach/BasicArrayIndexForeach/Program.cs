using System;

namespace BasicArrayIndexForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i + 10;
            }
            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Element[{0}] = {1}", j, nums[j]);

            }
            Console.WriteLine(  "-------------------------");
            int conter = 0;
            foreach (int k in nums)
            {
                Console.WriteLine("Element[{0}] = {1}",conter,k);
                conter++;
            }
            Console.WriteLine("===========================");
            string[] bestFriends =
            {
                "Olivia",
                "Jackey",
                "Vennena",
                "Hannah",
                "Lily"
            };
            foreach (string k in bestFriends)
            {
                Console.WriteLine("Hi!{0}! How are you? ",k);
            }
        }
    }
}
