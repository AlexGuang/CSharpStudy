using System;

namespace IfStatementCondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperature = 25;

            if (temperature < 10)
            {
                Console.WriteLine("Take the coat");
            }
            if (temperature == 10)
            {
                Console.WriteLine( "It's 10 degress C°");
            }
            if (temperature > 10)
            {
                Console.WriteLine("Cozy & warm!");
            }
        }
    }
}
