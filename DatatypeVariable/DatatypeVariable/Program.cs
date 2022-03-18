using System;

namespace DatatypeVariable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            /*
             * go ahead and create a variable for each of the primitive datatypes (you can find the list here).
             * Leave the Object datatype out. And also please initialize each variable with a working value.
            Then create two values of type string. 
            The first one should say "I control text"*/

            /*The second one should be a whole number. Then use the Parse method in order to convert that string to an integer.

            Add each an output for each of the variables and write it onto the console. (WriteLine)
            Feel free to name your variables as you like, but keep in mind, that my result's variable names will differ to yours.
             */
            byte myByte = 21;
            Console.WriteLine(myByte);
            sbyte mySByte = -43;
            Console.WriteLine(mySByte);
            int a = 320;
            uint ua = 3211;
            short b = 0;
            long c = 10000000000000;
            ulong uc = 23232;
            Console.WriteLine(uc);
            float f = 12.32f;
            double d = 2.141572533;
            char e = 'q';
            string s = "I control text";
            string t = "432432";
            bool ifyes = true;
            Console.WriteLine(ifyes);

            a = int.Parse(t);
            Console.WriteLine("The value of ‘a’ is: {0}",a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(s);
            Console.WriteLine(t);


        }
    }
}
