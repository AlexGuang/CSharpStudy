using System;
/* Create a small Console application to practice this.

Declare a string variable and don’t assign any value to it.

Print on the console “Please enter your name and press enter”. 
    
    You can then enter your name or any other valid string like “tutorials.eu”.

Assign that entered string to the string variable which you have declared initially.

The program should write on the console that string in Uppercase in the first line,

then the same string in Lowercase in the second line. In the third line, it writes on the console

the string with no trailing or preceding white space like if string entered as “ tutorials.eu ” it should 

be written on the console as “tutorials.eu”. And in the last line, it should write the Substring of the entered 

string on the console.

These kinds of features are e.g. used when creating a login screen, where the system will cut out trailing 

or preceding white space or, doesn’t care about the casing of the entered username.*/


namespace StringAndItsMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //console.writeline("hello world!");

            string iAmString; //Declare a string variable ;
            Console.WriteLine("Please input your name and press enter: "); //   a order to the client
            iAmString = Console.ReadLine(); //Input the name
            string upperIAmString = iAmString.ToUpper();
            string lowerIAmString = iAmString.ToLower();
            string trimIAmString = iAmString.Trim(); //Cut off all white space in the begining and end of the string.
            string subStringIAmString = iAmString.Substring(2);// From the third letter 


            Console.WriteLine(upperIAmString);
            Console.WriteLine(lowerIAmString);
            Console.WriteLine(trimIAmString);
            Console.WriteLine(subStringIAmString);// Print all the string variables;

        }
    }
}
