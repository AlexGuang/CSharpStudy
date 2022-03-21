using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    //Challenge:
    // add two more member variable to "Human". eyeColor and age.
    //adjust the constructor , so it requires all of the four values to be used, when creating an object of Human
    //create two objects of type Human.
    internal class Human
    {
        // member variable 
       private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        //constructor
        public Human(string firstName, string lastName, string eyeColor,int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        public  Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public Human(string myFirstName)
        {
            firstName = myFirstName;           
        }
        public Human()
        {           

        }

        //member method
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I'm {0} {1}, my eye is {2}, and I am {3} years old",firstName,lastName,eyeColor,age);
        }
    }
}
