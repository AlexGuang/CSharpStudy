using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge2
{
    internal class Employee
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        public Employee()
        {

        }
        public Employee(string name, string firstName, int salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }


        public virtual void Work()
        {
            Console.WriteLine("{0} is working.",FirstName);
        }
        public void Pause()
        {
            Console.WriteLine("{0} is having a rest.",FirstName);
        }
    }
}
