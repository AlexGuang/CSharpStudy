using System;

namespace ExplicitCoversionImplicitConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion
            int num = 1239034323;
            long bigNum;
            bigNum = num;

            float fnum = 12.2f;
            double myNewDouble = fnum;
            Console.WriteLine(bigNum );
            // explicit conversion
            double myDouble = 123.23;
            int myInt;
            //cast double to int
            myInt = (int)myDouble;

            // typeConversion
            string myString =  myDouble.ToString();//"123.23"
            string myNumString = num.ToString();
            string myFloatString = fnum.ToString();
            bool sunIsShining = false;
            string myBoolString = sunIsShining.ToString();
            Console.WriteLine(myInt);
            Console.WriteLine(myString);
            Console.WriteLine(myNumString);
            Console.WriteLine(myFloatString);
            Console.WriteLine(myBoolString);



            Console.ReadLine();
        }
    }
}
