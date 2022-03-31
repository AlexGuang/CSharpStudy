using System;

namespace ENUMLearning
{
    internal class Program
    {
        enum Month
        {
            Januray,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            Decmber

        }
        static void Main(string[] args)
        {
            Month month1 = Month.Januray;
            Console.WriteLine("{0}",month1);
            Month month2 = Month.February;
            Month month3 = Month.February;
            Console.WriteLine(month2 == month3);
        }
    }
}
