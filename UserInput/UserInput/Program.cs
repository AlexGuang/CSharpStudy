using System;

namespace UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input something");

            string input = Console.ReadLine();

            Console.WriteLine(input);
            
            string stringNum1;
            string stringNum2;


            Console.WriteLine("Now we gonna make an ADD:");
            Console.WriteLine("Please enter the first number");
            stringNum1 = Console.ReadLine();

            Console.WriteLine("Please enter the second number:");
            stringNum2 = Console.ReadLine();

            Console.WriteLine("The first number plus the second number is :{0}",Add(stringNum1,stringNum2));
        }
        /// <summary>
        /// add two number together
        /// </summary>
        /// <param name="num1"> it's a string but must be like a integer</param>
        /// <param name="num2">it's also a string but must be like a integer too</param>
        /// <returns></returns>
        public static int Add(string num1, string num2)
        {
            int num3 = int.Parse(num1);
            int num4 = int.Parse(num2);
            return num3 + num4;
        }
    }
}
