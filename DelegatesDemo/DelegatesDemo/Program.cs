using System;
using System.Collections.Generic;

namespace DelegatesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
           {
               new Person("Jack",19),
               new Person("Marry",20),
               new Person("Danis",22)
           };

            DisplayPeople("adult", people, Ifadult);
        }


        public static bool Ifadult(Person person)
        {
            if (person.Age < 21)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public delegate bool FilterDelegate(Person person);
        public static void DisplayPeople( string title, List<Person> people,FilterDelegate filter)
        {
            foreach (var person in people)
            {
                if (filter(person))
                {
                    Console.WriteLine("The {0} is {1} years old, an {2}.",person.Name,person.Age,title);
                }
               
            }
        }

    }
   
}
