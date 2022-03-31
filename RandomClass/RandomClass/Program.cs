using System;

namespace RandomClass
{
    internal class Program
    {
        public static Random randomNum = new Random();
        static void Main(string[] args)
        {
            Random yes = new Random();
           

            Console.WriteLine(" Will you give me money? 1 for yes,2 for maybe, 3 for no.");
            for (int i = 0; i < 6; i++)
            {
                int yesNo = yes.Next(1, 4);
                if (yesNo == 1)
                {
                    Console.WriteLine("yes");

                }
                else if (yesNo == 2)
                {
                    Console.WriteLine("maybe");
                }
                else
                    Console.WriteLine("no");

               
            }
        }
    }
}
