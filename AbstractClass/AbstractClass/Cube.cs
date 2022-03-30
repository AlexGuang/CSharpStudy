using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Cube : Shape
    {
        public double Length { get; set; }

        public Cube(double length)
        {
            this.Length = length;
            Name = "Cube";
        }
        public override double GetVolumn()
        {
            return Math.Pow(Length, 3);
        }
        public override void ShoeInfor()
        {
            base.ShoeInfor();
            Console.WriteLine("The Length of this cube is: {0}",Length);
        }
    }
}
