using System;

namespace TryCatchFinally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the first number:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please input the second number:");
            double b = double.Parse(Console.ReadLine());
            double c =0;
            c = a / b;
            try
            {
                 c = a / b;
            }
            catch (Exception)//never happens, maybe the double type can divde zero, let me do an experiment of integer.

            {

                Console.WriteLine("1. C的值是：{0}", c); 

            }
            Console.WriteLine("C的值是：{0}",c);

            int d = 5;
            int e = 0;
            //int result = d / e;//errror occurs,its DivideByZeroException'Attempted to divide by zero'. So we can
            //write a try here
            try
            {
                int result = d / e;
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("error, please do not divide zero, it cannot be divided by zero");
            }


            Console.WriteLine("Please enter a number");

            string userInput = Console.ReadLine();
            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {

                Console.WriteLine("Format exception, please enter the correct type next time");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, your input is too long or too short");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Arguement exception, Please do not input empty or null content");
            }
            finally
            {
                Console.WriteLine("This is anyway"); //Anyway, it will execute.
            }


        }
    }
}
