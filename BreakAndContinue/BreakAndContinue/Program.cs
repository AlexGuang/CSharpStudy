using System;

namespace BreakAndContinue
{
    internal class Program
    {
        // a small app to find out all odd numbers between 0 and 10.
        static void Main(string[] args)
        {
            int oddCount = 0;
            for (int counter = 0; counter < 10; counter++)
            {
                if (oddCount == 3)
                {
                    break;// Find 3 odd numbers,enough.
                }
                if (counter %2 == 0)
                {
                    Console.WriteLine("Now comes an Odd Number:");
                    continue;// continue can stop the current loop and jump to the next loop.
                }
                Console.WriteLine(counter);
                oddCount++;
            }


            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(i);
                if (i == 13)
                {
                    Console.WriteLine("Now it's 13, stop.");
                    break;//break stop the whole loop and jump to the next sytax after the for loop.
                }
            }
        }
    }
}
