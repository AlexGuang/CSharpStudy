using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideKeywords
{
    internal class Dog : Animal
    {
        public bool IsHappy { get; set; }
        public Dog(string name, int age) : base(name, age)
        {
            // all dogs are happy;
            IsHappy = true;
        }

        public override void Eat()
        {
            // to call the eat method from our base class we use the keyword "base"
            base.Eat();
        }

        public override void MakeSounds()
        {
            //Since every animal will make a totally different sound
            // Each animal will implement their own version of MakeSound
            Console.WriteLine("Wuuuf!");
        }

        public override void Play()
        {
            //Check if the dog is happy if yes call the Play method from the base class

            if (IsHappy)

            {
                base.Play();


            }
        }
    }
}
