using System;
using System.Collections.Generic;

namespace ChallengeOfInheritance
{
    internal class Program
    {

        //Create a base class Car with two properties HP and Color
        // Create a Constructor setting those two properties
        // Create a Method called ShowDetails() which shows the HP and Color of the car on the console
        //Create a Repair Method which writes "Car was repaired!" onto the console
        //Create two deriving classes, BMW and Audi, which have their own constructor and have an aditional property
        //called Model. Also a private member called brand.Brand should be different in each of the two classes.
        // Create the two methods ShowDetails() and Repair in them as well. Adjust those methods accordingly.
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>()
            { 
                new Audi(120,"black","A4" ),
                new BMW(130, "white", "c30")
            };

            foreach (Car car in cars)
            {
                car.ShowDetails();
                Console.WriteLine();
                car.Repair();
                Console.WriteLine("=========================================");
            
            }
            Car car1 = new Audi(140, "red", "Q4");
            Audi car2 = new Audi(130, "blue", "A6");//Key word "new" define the method "ShowDetails()" has a priority.
            car1.ShowDetails();
            car2.ShowDetails();
               
        }
    }
}
