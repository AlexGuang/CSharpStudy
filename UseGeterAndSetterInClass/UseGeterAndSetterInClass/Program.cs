using System;

namespace UseGeterAndSetterInClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(2, 3, 4);
            box.DescribeBox();
            box.SetLength(30);
            box.DescribeBox();

            box.Width = 7;
            box.Weight = 10;
            box.DescribeBox();
            Console.WriteLine("Front surface is {0}",box.FrontSurface);
        }
    }
}
