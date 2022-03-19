using System;

namespace IfStatementChallenge
{
    internal class Program
    {

        /*
         * Create a user Login System, where the user can first register and then Login in. 
         * The Program should check if the user has entered the correct username and password, wenn login in 
         * (so the same ones that he used when registering).
         * As we haven't covered storing data yet, just create the program in a way, that registering and logging in,
         *   happen in the same execution of it.
         *   User If statements and User Input and Methods to solve the challenge.  
         */
        static void Main(string[] args)
        {
            string userName = "";
            string password = "";

            if (HaveYouRegistered())
            {
                Console.WriteLine("You have registed, please log in");
                LogIn(userName,password);
            }
            else
            {
                GoRegister(out userName, out password);
                LogIn(userName,password);

            }


        }
        public static bool HaveYouRegistered()
        {
            string isRegistered;
            Console.WriteLine("Have you registered in the system ? Please input 'y' or 'n'");
            isRegistered = Console.ReadLine();
          
            if (isRegistered.Equals("y"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void GoRegister(out string userName, out string passWord)
        {

            Console.WriteLine("You are not the registered user, please register first.");
            Console.WriteLine("Please input your user name:");
            userName = Console.ReadLine();
            Console.WriteLine("Please input your password:");
            passWord = Console.ReadLine();
            Console.WriteLine("Your user name is:{0}",userName);
            Console.WriteLine("Your password is: {0}",passWord);
            Console.WriteLine("-------------------------------------------------------------------");

        }
        public static bool LogIn(string userName, string passWord)
        {
            Console.WriteLine("You are registered, please log in");
            Console.WriteLine("Please enter your user name:");
            string inputUserName = Console.ReadLine();
           // Console.WriteLine(inputUserName);
            Console.WriteLine("Please enter your password:");
            string inputPassWord = Console.ReadLine();

            if (inputUserName.Equals(userName) && inputPassWord.Equals(passWord))
            {
                Console.WriteLine("Congratulations! You have log in succefully!");
                return true;

            }
            else
            {
                Console.WriteLine("You user name and password are not correct, please exit.");
                return false;
            }
        }
    }
}
