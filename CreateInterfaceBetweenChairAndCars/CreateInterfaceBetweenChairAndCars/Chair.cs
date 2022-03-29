using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateInterfaceBetweenChairAndCars
{
    internal class Chair : Furniture, Idestructable
    {
        public string DestructSound { get; set; }
        public Chair(string color, string material) :base (color,  material) 
        {
            DestructSound = "ChairDestructSound.mp3";
        
        }

        public void Destroy()
        {
            Console.WriteLine(DestructSound);
            Console.WriteLine("Spawn chair parts");
            Console.WriteLine("The {0} chair begins burning.",Color);
        }
    }
}
