using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOfInheritance
{
    internal class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }
        public Car()
        {

        }
        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine("The {1} car has a HP of {0}",HP  ,Color);
        }
        public virtual  void Repair()
        {
            Console.WriteLine("Car was repaired!");
        }
    }
}
