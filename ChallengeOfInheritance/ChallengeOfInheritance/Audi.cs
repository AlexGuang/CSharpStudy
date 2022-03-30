using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOfInheritance
{
    internal class Audi:Car

    {
        public string FromCountry { get; set; }
        public string Model { get; set; }
        private string brand = "Audi";
        public Audi()
        {

        }
        public Audi(int hp, string color,string model ): base(hp, color)
        {
            this.FromCountry = "Germany";
            Model = model;
          
        }
        public new void ShowDetails()
        {
            Console.WriteLine("This {3} car is {0},which is from {1}, the model is {2}, and it has {4} horse power!", brand, FromCountry, Model, Color, HP);
        }
        public override void Repair()
        {
            Console.WriteLine("The {0}  {1} is broken!", Color, brand);
            base.Repair();
        }
    }
}
