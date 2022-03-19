using System;

namespace IfElseIfTryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperatureNum;
            int number;


            Console.WriteLine("Please enter the temperature now");

            if (int.TryParse(Console.ReadLine(),out number))
            {
                temperatureNum = number;
            }
            else
            {
                Console.WriteLine("Your input is not appropriate, program closed");
                return;
            }

            if (temperatureNum < 10)
            {
                Console.WriteLine(" It's so cold today, do not forget to take a coat");

            }
            else if (temperatureNum < 20)
            {
                Console.WriteLine("It's warm today, lets do some exercises together");

            }
            else
            {
                Console.WriteLine("It's hot today, let's take a shower together");
            }

        }
    }
}
