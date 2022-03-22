using System;

namespace Basic2DArrayAndNestedForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numArray =
            {         
                  { 1, 2, 3 }, 
                  { 4, 5, 6 }, 
                  { 7, 8, 9 },                
            };

            for (int i = 0; i < numArray.GetLength(0); i++)
            {
                for (int j = 0; j < numArray.GetLength(1); j++)
                {
                    if (numArray[i,j] % 2 == 0)
                    {
                        Console.WriteLine(numArray[i, j]);
                    }
                }
            }
        }
    }
}
