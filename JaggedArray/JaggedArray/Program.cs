using System;

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region jaggedArray study
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[3];
            jaggedArray[1] = new int[2];
            jaggedArray[2] = new int[5];

            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 1, 2 };
            jaggedArray[2] = new int[] { 5, 4, 3, 2, 1 };

            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 1, 2, 6,8,6},
                new int[] { 1, 2, 6},
                new int [] { 1, 2, 3}

            };

            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)// inner array. length, never use getLength()
                {
                    Console.WriteLine("The value of jaggedArray[{0}][{1}] is : {2}", i, j, jaggedArray[i][j]);
                }
            }
            #endregion

            #region A jaggedArray  challenge/ practice
            /*
             Create a jagged array, which contains 3 "friends arrays", in which two family members should be stored
             Introduce family members from different families to each other via console (three introductions)
             */
            string[][] friendsArrays = new string[3][];
            friendsArrays[0] = new string []{ "Marry", "Hannah"};
            friendsArrays[1] = new string[]{ "Machel", "Harry"};
            friendsArrays[2] = new string[] { "Anna", "Joe" };

            for (int k = 0; k <friendsArrays.Length; k++)
            {
                Console.WriteLine("This is the No.{0} friend family.",k);
                for (int l = 0; l < friendsArrays[k].Length; l++)
                {
                    Console.WriteLine("And this is {0}.", friendsArrays[k][l]) ;
                }
            }
            #endregion
        }
    }
}
