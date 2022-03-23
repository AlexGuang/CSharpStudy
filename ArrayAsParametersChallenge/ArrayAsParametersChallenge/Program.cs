using System;

namespace ArrayAsParametersChallenge
{
    internal class Program
    {
        /*
         * CHALLENGE - Create an array of happiness in the main method and assign 5 values to it.
         * Create a method which has an array of type int as its parameter.
         * This method should increase the argument given by 2, for each entry.
         * Call this method in the main method and use "happiness" as the argument.
         * Create a foreach loop in the main method to write all values onto the console.
         */
        static void Main(string[] args)
        {
           int [] happiness = { 1, 2, 3, 4, 5 };
           IncreseArray(happiness);
            foreach (var item in happiness)
            {
                Console.WriteLine(item);
            }
            
        }
        public static void IncreseArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 2;
            }
        }
    }
}
