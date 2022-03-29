using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge2
{
    internal class Boss : Employee
    {
        public string CompanyCar { get; set; }
        public Boss(string name, string firstName, int salary): base(name, firstName, salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }


        public void Lead()
        {
            Console.WriteLine("I, {0} is leading",FirstName);
        }
    }
}
