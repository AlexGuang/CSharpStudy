using System;

namespace ObjectOrientedProgramLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //create an object of my class
           // an instance of Human
            Human xiaoguang = new Human();
            //access public variable from outside, and even change it
            xiaoguang.firstName = "XIAOGUANG";
            //call method of it
            xiaoguang.IntroduceMysel();

            Human jack = new Human();
            jack.firstName = "JACK";
            jack.lastName = "SMITH";


            Human allen = new Human();
            allen.firstName = "ALLEN";
            allen.lastName = "SOON";

            jack.IntroduceMysel();
            allen.IntroduceMysel();



        }
    }
}
