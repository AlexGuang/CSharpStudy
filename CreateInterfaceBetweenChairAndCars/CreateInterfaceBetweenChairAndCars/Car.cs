using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateInterfaceBetweenChairAndCars
{
    internal class Car:Vehical,Idestructable

    {
        public string DestructSound { get; set; }
        public List<Idestructable> DestructableNearby;
        public Car(double speed, string color) : base(speed, color)
        {
            DestructSound = "CarExplosionSound.mp3";
            DestructableNearby = new List<Idestructable>();
        }

        public void Destroy()
        {
            Console.WriteLine(DestructSound);
            Console.WriteLine("Fire on the car begins!");

            foreach (Idestructable destructable in DestructableNearby)
            {
                destructable.Destroy();
                    
            }
          
        }
    }
}
