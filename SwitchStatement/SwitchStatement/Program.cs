using System;

namespace SwitchStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 25;

            switch (age)
            {
                case 15:
                    Console.WriteLine("Too young to party in the club!");
                    break;
                case 25:
                    Console.WriteLine("Good to go!");
                    break;
                case 49:
                    Console.WriteLine("Too old to go dance");
                    break;
                default:
                    Console.WriteLine("How old are you then?");
                    break;
            }// The switch statement has same functions as the below if statement
            if (age == 15)
            {
                Console.WriteLine("Too young to party in the club!");
            }
            else if (age == 25)
            {
                Console.WriteLine("Good to go!");
            }
            else if (age == 49)
            {
                Console.WriteLine("Too old to go dance");
            }
            else
            {
                Console.WriteLine("How old are you then?");
            }
            //return;
            string username = "Xiaoguang";
            switch (username)
            {
                case "Xiaoguang":
                    Console.WriteLine("username is Xiaoguang ");
                    break;
                case "Alex":
                    Console.WriteLine("username is Alex");
                    break;


                default:
                    Console.WriteLine("username is unknown");
                    break;
            }
        }
    }
}
