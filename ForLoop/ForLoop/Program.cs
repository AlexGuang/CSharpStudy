using System;

namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter);

            }
            Console.WriteLine("For loop is done!");


            //Challenge 1:Use a for loop to print all odd numbers from zero to twenty.
            Console.WriteLine("Please write a for loop to print odd numbers from zero to twenty");
            for (int i = 1; i < 20; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("All odd numbers from zero to twenty have been printed.");
        }
    }
}
