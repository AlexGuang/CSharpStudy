using System;

namespace MainArgsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"+ args[0]);
            foreach (string item in args)
            {
                Console.WriteLine(item);
            }
            //The args array cannot be null. So, it's safe to access the length property without null checking.
            // So we check the length of the array if it's zero it means arguments were provided to the application 
            if (args.Length == 0)
            {
                Console.WriteLine("This is a smart app that uses args;), Please provide arguments next time");
                //Pause the application so it does't quite after pritning our error message
                Console.ReadKey();
                //Quit the application entirely since we cannot proceed further since, the arguments are empty
                return;
            }
            Console.WriteLine("Hello" + args[0]);
        }
    }
}
