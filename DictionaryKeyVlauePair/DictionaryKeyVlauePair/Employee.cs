using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryKeyVlauePair
{
    internal class Employee
    {
        public string Position { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Rate { get; set; }


        public Employee(string position, string name, int age, int rate)
        {
            this.Position = position;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;

            
        }
    }
}
