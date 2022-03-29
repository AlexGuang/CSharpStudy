using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateInterfaceBetweenChairAndCars
{
    internal class Vehical
    {
        public double Speed { get; set; }
        public string color { get; set; }

        public Vehical()
        {

        }
        public Vehical(double speed, string color)
        {
            this.Speed = speed;
            this.color = color;
        }
    }
}
