using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramLearning
{
    //challenge:
    // create a public  variable lastName of type string.
    // change the IntroduceMyself method, so it tells the whole name.
    // create two objects with full information about themself - firstName and lastName
    internal class Human
    {
        //member variable
        public string firstName;
        public string lastName;

        // member function
        public void IntroduceMysel()
        {
            Console.WriteLine("Hi, I'm {0} {1} .",firstName,lastName);
        }
    }
}
