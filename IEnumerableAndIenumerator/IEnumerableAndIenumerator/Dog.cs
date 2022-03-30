using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableAndIenumerator
{
    internal class Dog
    {
        public string Name { get; set; }
        public bool  IsNaughty { get; set; }
        public Dog(string  name , bool isNaughtyDog)
        {
            this.Name = name;   
            this.IsNaughty = isNaughtyDog;
        }

        public void GiveTreat(int a)
        {
            Console.WriteLine("The dog {0} said Wuoff {1} times! ",Name,a);
        }
    }
}
