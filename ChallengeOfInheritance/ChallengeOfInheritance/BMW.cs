using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOfInheritance
{
    internal class BMW:Car
    {
        public int SetYear { get; set; }
        public string Model { get; set; }
        private string brand = "BMW";

        public BMW(int hp, string color, string model) : base(hp, color)
        {
            SetYear = 1929;
            Model = model;
            
        }

        public new void ShowDetails()
        {
            Console.WriteLine("This {3} car is {0},which is set up in {1}, the model is {2}, and it has {4} horse power!",brand,SetYear,Model,Color,HP);
        }
        public override void Repair()
        {
            Console.WriteLine("The {0}  {1} is broken!",Color,brand);
            base.Repair();
        }
    }
}
