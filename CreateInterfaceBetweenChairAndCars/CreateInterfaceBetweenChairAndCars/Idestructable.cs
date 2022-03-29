using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateInterfaceBetweenChairAndCars
{
    internal interface Idestructable
    {
        public string DestructSound { get; set; }

        public void Destroy()
            { }
    }
}
