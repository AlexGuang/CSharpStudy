using System;

namespace EnhancedIfStatementTernaryOperatorChallenge
{
    internal class Program
    {
        /*
         create a small application that takes a temperature value as input and checks if the input is an integer or not.

If the input value is not an integer value, it should print to the console "Not a valid Temperature".

And if the input value is the valid integer then it should work as mentioned below.

If input temperature value is <=15 it should write "it is too cold here" to the console.

If input temperature value is >= 16 and is <=28 it should write "it is ok" to the console.

If the input temperature value is > 28 it should write "it is hot here" to the console.

Make sure to use ternary operators and not if statements to check for the three conditions, 
        
 however you can use if statement for the other conditions like to check if the entered value is a 
 
        valid integer or not.


         */
        static void Main()
        {
            Console.WriteLine("Please input the current temperature:");
            string inputValue = string.Empty;
            inputValue = Console.ReadLine();
            int number ;

            if (int.TryParse(inputValue, out number))
            {
                Console.WriteLine("The value  is  a integer.");
            }
            else
            {
                Console.WriteLine("Your input is not correct. Please exit.");
                return;
            }
            string stateOfWeather = number > 28 ? "It is hot" : number <= 15 ? "It is cold" : "It is ok";
            Console.WriteLine(stateOfWeather);
        }
    }
}
