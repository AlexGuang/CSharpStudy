using System;

namespace EnhancedIfStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // condition ? first_expression : second_expression;
            //conditon has to be either true or false
            //The conditional operator is right - associative.
            //The expression a ? b :(c ?d:e),
            //not as (a? b : c) ? d:e
            //The condition operator cannot be overloaded

            // in celcius
            int temperature = -5;
            string stateOfWater;
            
              if (temperature > 0)
            {
                stateOfWater = "liquid";
            }
            else
            {
                stateOfWater = "solid";
            }


            Console.WriteLine(" State of water is {0}", stateOfWater);

            //in short:
            temperature += 39;
            stateOfWater = temperature < 0 ? "solid" : "liquid";
            Console.WriteLine(" State of water is {0}", stateOfWater);
            temperature += 100; 
            stateOfWater = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";// This looks awesome!


            Console.WriteLine(" State of water is {0}", stateOfWater);

        }
    }
}
