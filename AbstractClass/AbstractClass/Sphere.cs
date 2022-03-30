using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Sphere:Shape
    {
        public double Radius { get; set; }

        public Sphere( double radius)
        {
            this.Radius = radius;
            this.Name = "Sphere";
        }
        public override double GetVolumn()
        {
            return Math.Pow(Radius, 3) * Math.PI * 4 / 3;
        }
        public override void ShoeInfor()
        {
            base.ShoeInfor();
            Console.WriteLine("The radius of this sphere is {0}", Radius);
        }
    }
}
