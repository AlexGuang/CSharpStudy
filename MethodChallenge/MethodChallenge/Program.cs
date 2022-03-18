using System;

namespace MethodChallenge
{
    internal class Program
    {

        /*
         In this challenge you will deepen your understanding for methods.
        Please go ahead and create three variables with names of your friends.
Then create a Method "GreetFriend" which writes something like: "Hi Frank, my friend!" onto the console, once it is called.
Where "Frank" should be replaced with the Name behind the argument given to the Method when 
        it's called. So the method will need a parameter (decide which DataType will be best). 
         
         */
        static void Main(string[] args)
        {
            string a = "Tom";
            string b = "Jack";
            string c = "Olivia";

            GreetFriend(a);
            GreetFriend(b);
            GreetFriend(c);


        }

        public static void GreetFriend(string friendName)
        {
            Console.WriteLine("Hi, {0}, my friend!",friendName);
        }
    }
}
