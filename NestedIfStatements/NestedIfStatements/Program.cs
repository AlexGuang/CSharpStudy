using System;

namespace NestedIfStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("Please enter your user name");

            userName = Console.ReadLine();

            if (isRegistered && userName.Equals("Alex"))
            {
                Console.WriteLine("Hi there, registered user");
                if (userName != "")
                {
                    Console.WriteLine("Hi there, {0}",userName);
                    if (userName.Equals("Admin"))
                    {
                        Console.WriteLine("Hi there, Admin");
                    }
                }
            }
            else
            {

                return;
            }
            if (isAdmin || isRegistered)
            {
                Console.WriteLine("You are logged in");
            }
        }
    }
}
