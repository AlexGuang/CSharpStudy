using System;

namespace ThreeWaysToCreateAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int []grades  = new int[5];
            grades[0] = 34;
            grades[1] = 21;
            grades[2] = 43;
            grades[3] = 323;
            grades[4] = 53;
            foreach (var item in grades)
            {
                Console.WriteLine(item);
            }
            int[] scoreOfClass =
            {
                56,64,42,46,56,75,75,84,43,38
            };
            foreach (var item in scoreOfClass)
            {
                Console.WriteLine(item);

            }
            string[] teacherNames = new string[]
            {
                "Wang Gang",
                "Zhang San",
                "Li Si",
                "Chen Tong",
                "Liu Caixie",
                "Ma Hongjuan"

            };
            foreach (var item in teacherNames)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("============================================");
            for (int i = 0; i < teacherNames.Length; i++)
            {
                Console.WriteLine(teacherNames[i]);
            }
            Console.WriteLine("-----------------------------------------------");
        }
    }
}
