using System;

namespace StringManipulate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string manipulation
            // define few variable
            int age = 31;
            string name = "Alfonso";
            string job = "Developer";

            //1. string concatenation
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello my name is " + name + " , I am " + age + " years old.");

            //2. String formating.
            // string formatting uses index
            Console.WriteLine("String Formatting");
            Console.WriteLine("Hello my name is {0}， I am {1} years old, and I am a {2}. ",name, age, job);


            //3. String interpolation.
            // string Interpolation uses $ at the start which will allow us to write our
            // variables like this{variable}

            Console.WriteLine("String interpolation");
            Console.WriteLine($"Hello my name is {name}, I am {age} years old.", name, age);
            Console.WriteLine($"Hello my name is {name}, I am {age} years old.");// as same as above;


            //4. Verbatim strings.
            //verbatim strings start with @ and tells the compoler to take the string literally and ignore any
            //spaces and escape characters like \n
            Console.WriteLine("Verbatim Strings");
            Console.WriteLine(@"Lorem ipsum dolor i");
        }
    }
}
