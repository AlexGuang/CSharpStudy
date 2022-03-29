using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateInterfaceBetweenChairAndCars
{
    internal class Furniture
    {
        public string Color { get; set; }
        public string Material { get; set; }

        public Furniture()
        {

        }
        public Furniture(string color, string material)
        {
            this.Color = color;
            this.Material = material;
        }
    }
}
