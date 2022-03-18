using System;

namespace HelloWorldSring
{
    internal class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            string myname = "Xiaoguang";

            string message = "My name is " + myname;

            string capsMessage = message.ToUpper();

            string lowerCaseMessage = message.ToLower();

            Console.WriteLine();

            Console.WriteLine("My name is : " + myname);
            Console.WriteLine(capsMessage);

            Console.WriteLine(lowerCaseMessage);
            Console.Read();


           

        }
    }
}
