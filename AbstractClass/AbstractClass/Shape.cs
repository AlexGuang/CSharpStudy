using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal abstract class Shape
    {
        public string Name { get; set; }
        public Shape()
        {

        }
        public Shape(string name)
        {
            this.Name = name;
        }
        public virtual void ShoeInfor()
        {
            Console.WriteLine("It's name is {0}",Name);
        }

        public abstract double GetVolumn();
    }
}
