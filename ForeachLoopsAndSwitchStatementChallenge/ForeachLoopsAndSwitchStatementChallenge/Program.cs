using System;

namespace ForeachLoopsAndSwitchStatementChallenge
{
    internal class Program
    {
        /*
         Create an application that takes 2 input values.

Any input value (1st input)

Asks the data type of the input value. (2nd input)

It will print to the console the options like below to take input for the 2nd input value:

Press 1 for String

Press 2 for integer

Press 3 for Boolean

If the input value for the 2nd input is 1 then the application should check that if the entered 1st input is a valid string or not. Hereby we even want to check, if it is a complete alphabetic entry (so no numbers accepted)

If the input value for the 2nd input is 2 then the application should check if the entered 1st input is a valid integer or not.

Based on the input the 1st value and the selection of data type using the 2nd input, the application should return whether the entered 1st value is of data type selected by the user or not.

Please make sure to use a switch statement. To check the valid string you can write your custom logic.

For example:

Enter a value: {here you can enter any value}

Select the Data type to validate the input you have entered.

Press 1 for String

Press 2 for Integer

Press 3 for Boolean

Here, if you enter 1 it should return below message

You have entered a value: Denis Panjuta

It is a valid: String

Here, if you enter 2 it should return below message

You have entered a value: Denis Panjuta

It is an invalid: Integer


         */
        static void Main(string[] args)
        {
            string firstInput;
            string secondInput;
            bool isString;
            bool isInt;


            Console.WriteLine("Please enter a value:");
            firstInput = Console.ReadLine();
            Console.WriteLine("Please select a data type to validate the input you have entered:" +
                "\n Press 1 for String" +
                "\n Press 2 for Integer" +
                "\n Press 3 for Boolean");
            secondInput = Console.ReadLine();
            switch (secondInput)
            {
                case "1":
                    Console.WriteLine("You have enteren a value:{0}," +
                        "\n" +
                        "----------------------------------------------------" +
                        "\n" +
                        "{1}",firstInput,CheckString(firstInput)? "it is a valid :String.":"it is an invalid : String"); 
                    break;
                case "2":
                    
                    Console.WriteLine("You have enteren a value:{0}, " +
                        "\n" +
                        "----------------------------------------------------" +
                        "\n" +
                        "{1}", firstInput, CheckIntege(firstInput) ? "it is a valid :Integer." : "it is an invalid : Integer");
                    break;
                case "3":
                    Console.WriteLine("Haha, it does not work. *_*");
                    break;
                default:
                    Console.WriteLine("Please only press '1', '2' or '3'");
                    break;
            }
        }
        public static bool CheckString(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '1':
                        return false;
                    case '2':
                        return false;
                    case '3':
                        return false;
                    case '4':
                        return false;
                    case '5':
                        return false;
                    case '6':
                        return false;
                    case '7':
                        return false;
                    case '8':
                        return false;
                    case '9':
                        return false;
                    case '0':
                        return false;                    
                    default:
                        break;
                       
                }
            }
            return true;
        }
        public static bool CheckIntege(string firstInput)
        {
            if (int.TryParse(firstInput,out int result))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
//Console.WriteLine("You have enteren a value:{0},{1}", firstInput, CheckIntege(firstInput) ? "it is a valid :Integer." : "it is an invalid : Integer");
//Console log()