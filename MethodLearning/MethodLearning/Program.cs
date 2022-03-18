using System;

namespace MethodLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("I am an argument and am called from a method");
            Console.Read();
        }
        /// <summary>
        /// This method is just write something
        /// </summary>
        public static void WriteSomething()//access specifier (static) returnType methodName (paramter1, paramter2) 
        {
            Console.WriteLine("I am called from a method");
          
        }
        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
          
        }
    }
}
