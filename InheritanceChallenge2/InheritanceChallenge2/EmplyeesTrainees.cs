using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge2
{
    internal class EmplyeesTrainees:Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }
        public EmplyeesTrainees()
        {

        }

        public EmplyeesTrainees(string name, string firstName, int salary) : base(name, firstName, salary)
        {
        
        }
        public EmplyeesTrainees(string name, string firstName, int salary, int workhours, int schoolHours)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
            this.WorkingHours = workhours;
            this.SchoolHours = schoolHours;
        }
        public void Learn()
        {
            Console.WriteLine(" I,{1} am learning and my school hours is {0}",SchoolHours,FirstName);
        }

        public override void Work()
        {
            Console.WriteLine("The work hours of {1} is {0}",WorkingHours,FirstName);
        }
    }
}
