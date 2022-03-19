using System;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;


            // unary operators
            num3 = -num1;
            Console.WriteLine("num3 is: {0}", num3);

            bool isSunny = true;
            Console.WriteLine("is it sunny? \n {0}",!isSunny);


            //increment operators
            int num = 0;
            num++;
            Console.WriteLine("num is: {0}", num);
            Console.WriteLine("num is: {0}", num++);//post increment
            Console.WriteLine("num is: {0}", num);
            // pre increment
            Console.WriteLine("num is: {0}", ++num); //difference of num++ and ++num;
            Console.WriteLine("num is: {0}", num);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Now we gonna do the decrement");
            //decrement operator：num--
            Console.WriteLine("num is: {0}", num--);//post decrement
            Console.WriteLine("num is: {0}", num);
            Console.WriteLine("num is: {0}", --num);// pre decrement
            Console.WriteLine("num is: {0}", num);



            Console.WriteLine();
            Console.WriteLine();

            int result;

            result = num1 + num2;
            Console.WriteLine("result of num1 + num2 is: {0}", result);
            result = num1 - num2;
            Console.WriteLine("result of num1 - num2 is: {0}", result);
            result = num1 * num2;
            Console.WriteLine("result of num1 * num2 is: {0}", result);
            result = num1 / num2;
            Console.WriteLine("result of num1 / num2 is: {0}", result);
            result = num1 % num2;
            Console.WriteLine("result of num1 % num2 is: {0}", result);

            //relational and type operators
            bool isLower;
            isLower = num1 < num2;

            Console.WriteLine("result of num1 < num2 is :{0}", isLower);

            //equality operator
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine("result of num1 == num2 is :{0}", isEqual);

            isEqual = num1 != num2;
            Console.WriteLine("result of num1 != num2 is :{0}", isEqual);


            //conditional operator()
            Console.WriteLine("isLower is :{0}", isLower);
            bool isLowerAndSunny;
            //conditon1 AND conditon2
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("result of isLower && isSunny is: {0}", isLowerAndSunny);


            //CONDITON1 OR CONDITION2
            isLowerAndSunny = isLower || isSunny;
            Console.WriteLine("result of isLower || isSunny is: {0}", isLowerAndSunny);


        }
    }
}
