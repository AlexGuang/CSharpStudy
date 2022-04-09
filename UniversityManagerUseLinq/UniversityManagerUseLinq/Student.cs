using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagerUseLinq
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public int UniversityID { get; set; }



        public void Print()
        {
            Console.WriteLine("Student  ID: {4}, name:{0}, age: {1}, gender: {2}, universtity Id: {3}",Name,Age,Gender,UniversityID,Id);
        }
    }
}
