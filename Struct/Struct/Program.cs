using System;

namespace Struct
{
    internal class Program
    {
        public struct Game//struct can implement interfaces,but not inheritance
        {
            public string name;
            public string developer;// struct can have member variables.
            public double rating;
            public string releaseDate;

            public Game(string name,string developer,double rating,string releaseDate     )//struct cannot have the default constructor,
                //all parameters should be assigned.
            {
               this.name = name;
                this.developer = developer;
                this.rating = rating;
                this.releaseDate = releaseDate;
            }
            public void Display()//struct can have methods
            {
                Console.WriteLine("The name of the game is {0}", name);
                Console.WriteLine("It was developed by {0}", developer);
                Console.WriteLine("It has a rating of {0}", rating);
                Console.WriteLine("It was released on: {0}",releaseDate);
            }
        }

        static void Main(string[] args)
        {
          Game game = new Game("丸者与龙庙","Xiaoguang Li",5.00,"2022/12/05");
            game.Display();
        }
    }
}
