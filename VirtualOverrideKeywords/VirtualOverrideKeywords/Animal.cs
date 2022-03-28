using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideKeywords
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public bool IsHungry { get; set; }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.IsHungry = true;
        }

        public virtual void MakeSounds()
        {
            Console.WriteLine("The {0} makes a sound!", this.Name);
        }

        public virtual void Eat()
        {
            if (IsHungry)
            {
                Console.WriteLine("The {0} is eating!",this.Name);
            }
            else
            {
                Console.WriteLine("The {0} is not hungry!", this.Name);
            }
         

        }
        
        public virtual void Play()
        {
            Console.WriteLine("The {0} is playing, it has fun! ",this.Name);
        }

    }
}
