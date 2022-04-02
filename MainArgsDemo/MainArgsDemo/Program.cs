using System;

namespace MainArgsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //The args array cannot be null. So, it's safe to access the length property without null checking.
            // So we check the length of the array if it's zero it means arguments were provided to the application 
            if (args.Length == 0)
            {
                Console.WriteLine("This is a smart app that uses args;), Please provide arguments next time" +
                    "Please provide arguments next time. Pass Help if you want to get more details");
                //Pause the application so it does't quite after pritning our error message
                Console.ReadKey();
                //Quit the application entirely since we cannot proceed further since, the arguments are empty
                return;
            }
            //Check if the first command we got is help
            if (args[0] == "help")
            {
                //Display manual
                Console.WriteLine("***********************************Instructions:");
                Console.WriteLine("* Use one of the following commands followed by 2 numbers");
                Console.WriteLine("* 'add' : to add 2 numbers ");
                Console.WriteLine("* 'sub' : to subtract 2 numbers");
                Console.WriteLine("****************************************");
            }
            if (args.Length != 3)
            {
                Console.WriteLine("Invalid arguments, please use the help command for instructions");
                //Pause
                Console.ReadKey();
                //quit the app
                return ;
            }
            //In c# 6 and earlier, you must declare a variable in a separate statement before you pass it as an out argument
            //Since if the parsing operation fails the variable passed as out will have it's default value if it was a va
            //it it more logical to declare and pass the variable in the same line.
            bool isNum1Parsed = float.TryParse(args[1],out float num1);
            bool isNum2Parsed = float.TryParse(args[2],out float num2);

            if (!isNum1Parsed || !isNum2Parsed)
            {
                Console.WriteLine("Invalid arguments, please use the help command for instructions");
                //pause
                Console.ReadKey();
                //quit the app
                return;
            }
            float result;
            switch (args[0])
            {
                //case 1 'add' add the two numbers and print the value
                case "add":
            result = num1 + num2;
            Console.WriteLine("The sum of {0} and {1} is {2}", num1, num2, result);
            break;
                    //case 2 'sub' subtract the two numbers and print the value
                case "sub":
                result = num1 - num2;
                    Console.WriteLine("The sub of {1} and {0} is {2}",num2,num1,result);
                    break;
                //default case, here we handle wrong commands by printing an error message
            default:
                    Console.WriteLine("Invalid arguments, please use the help command for instructions");
                    break;
            }

            Console.WriteLine("Hello" + args[0]);

            //pause
            Console.ReadKey();
            return;
        }
    }
}
