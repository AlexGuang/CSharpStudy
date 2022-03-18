using System;

/*
 Create another console application for more practice.

This application asks the user to input a string in the first line like “Enter a string here: ”.

In the Second Line, it should ask for the character to search in the string which you have entered in 

the first line like “Enter the character to search: ”

On the third line, it should write the index of the first occurrence of the searched character from the string.


 */

namespace StringAndMethod2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            string enterString;// a variable to store the input string
            Console.WriteLine(" Please enter a string here: ");// Client guide
            enterString = Console.ReadLine();// input the string
            Console.WriteLine("Please enter a character to search in the string you entered");//Client guide 2
            char enterCharacter = Console.ReadLine()[0];//Enter a character, readline returns a string
            int indexCharacter = enterString.IndexOf(enterCharacter); // find the index
            Console.WriteLine(" The index of the character in the string {0} is :{1}",enterCharacter, indexCharacter);//string formating



            /*Now on concatenation...

It should then ask to enter the first name and once the name is written and the enter button is pressed, 

it should ask to enter the last name.

It should then show your full name printed in a single line like in my case the output will be "Denis Panjuta".

Output can be different in your case. Try to store the full name in a variable, before displaying it.*/
            string firstName;
            string lastName;
            string fullName;



            Console.WriteLine(" Please enter your first name");
                       
            firstName = Console.ReadLine();
            
            Console.WriteLine("Please enter your last name");
            
            lastName = Console.ReadLine();
            
            fullName = String.Format("{0} {1}",firstName,lastName);
            
            Console.WriteLine(fullName);
            //test git





        }
    }
}
