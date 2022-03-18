using System;

namespace Constants
{
    // Constants are immutable values which are known
    // at compile time and do not change for the life of the program.
    internal class Program
    {
        //constants as fields
        const double PI = 3.141592653;
        const int weeks = 52, months = 12;
        //Create a constant of type string with your birthday as its value;
        const string birthday = "02/05/1990";

        static void Main(string[] args)
        {
            Console.WriteLine("My birthday is {0}", birthday);

        }
    }
}
