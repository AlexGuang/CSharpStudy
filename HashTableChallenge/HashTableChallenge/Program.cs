using System;
using System.Collections;

namespace HashTableChallenge
{
    internal class Program
    {
        //Challenge:
        /*Write a program that will iterate through each element of the students array and insert them into a hashtable.
         * If a student with the same ID already exists in the hashtable skip it and display the following error:
         * "Sorry, A student with the same ID already Exists".
         * Hint: Use the method Containskey() to check wether a student with the same ID already exist.      
         */
        static void Main(string[] args)
        {
            Hashtable studentTable = new Hashtable();
            int idInput = 0;
            string idString;
            string nameInput;
            while (true)
            {

                    do
                {
                    Console.WriteLine("Please input the Id:");
                    idString = Console.ReadLine();

                } while (!int.TryParse(idString, out idInput));

           
                

            
                if (studentTable.ContainsKey(idInput))
                {
                    Console.WriteLine("Sorry, a student with the same ID already Exists");
                }
                else
                {
                    Console.WriteLine("Please input the Name:");
                    nameInput = Console.ReadLine();
                    studentTable.Add(idInput, nameInput);
                    Console.WriteLine("Student with ID {0} was added.",idInput);
                }
            }
          

        }
    }
}
