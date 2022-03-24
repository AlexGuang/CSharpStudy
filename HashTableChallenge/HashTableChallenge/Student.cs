using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableChallenge
{
    internal class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public Student(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
