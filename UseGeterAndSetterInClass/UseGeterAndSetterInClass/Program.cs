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
            

        }
    }
}
