using System;

namespace NullableVariable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 3;
            double? num3 = null;
            double? num4 = 16.96;
            
            bool? isMale = null;
            Console.WriteLine("num1:{0}, num2:{1}, num3:{2}, num4:{3}", num1, num2, num3, num4);
            if (isMale == true)
            {
                Console.WriteLine("User is male");
            }
            else if (isMale == false)
            {
                Console.WriteLine("User is female");
            }else
            {
                Console.WriteLine("Cannot check the user's gender.");
            }

            double? num5 = 16.96;
            double? num6 = null;
            double num7;

            if (num5 == null)
            {
                num7 = 0.00;
            }
            else
            {
                num7 = (double)num5;
            }
            Console.WriteLine("Value of num7 is {0}",num7);

            num7 = num6 ?? 8.53;// if num6 is null?  yes, num7 =8.53     no, num7=num6
            Console.WriteLine("Value of num7 is {0}", num7);

            num7 = num5 ?? 16.3;//对num5进行判断，如果num5 是null, 那么 num7 = 16.3, 否则的话num7 = num5
            Console.WriteLine("Value of num7 is {0}", num7);
        }
    }
}
