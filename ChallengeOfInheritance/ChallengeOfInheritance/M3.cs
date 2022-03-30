using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOfInheritance
{
    internal class M3:BMW
    {
        public M3(int hp, string color, string model) : base(hp, color, model)
        {
            SetYear = 1929;
            Model = model;

        }
      /*  public override void Repair()//Class BMW has sealed the method Repair(), so this child class cannot override it.
        {
            base.Repair();
        }
      */
    }
}
