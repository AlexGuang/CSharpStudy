using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagerUseLinq
{
    internal class UniversityManager
    {
        List<Student> students;
        List<University> universities;


       public UniversityManager()
        {
            students = new List<Student>();
            universities = new List<University>();

            universities.Add(new University { Id = 1, Name = "Yale" });
            universities.Add(new University { Id = 2, Name = "Beijing Tech" });

            students.Add(new Student { Id = 1, Name ="Carla",Gender ="female",Age = 22,UniversityID = 1});
            students.Add(new Student { Id = 2, Name = "Tony", Gender = "male", Age = 19, UniversityID = 1 });
            students.Add(new Student { Id = 3, Name = "Frank", Gender = "male", Age = 21, UniversityID = 1 });
            students.Add(new Student { Id = 4, Name = "Lydia", Gender = "female", Age = 20, UniversityID = 2 });
            students.Add(new Student { Id = 5, Name = "Joe", Gender = "male", Age = 20, UniversityID = 2  });
            students.Add(new Student { Id = 6, Name = "Linda", Gender = "female", Age = 19, UniversityID = 2 });
            students.Add(new Student { Id = 7, Name = "James", Gender = "male", Age = 18, UniversityID = 2 });
            students.Add(new Student { Id = 8, Name = "Micheal", Gender = "male", Age = 23, UniversityID = 1 });
            students.Add(new Student { Id = 9, Name = "Veneanna", Gender = "female", Age = 24, UniversityID = 2 });
        }

        public void GetFemaleStudent()
        {
            Console.WriteLine("Female students are:");
            IEnumerable<Student> femaleStudents = from student in students where student.Gender.Equals("female") select student;
            foreach (Student student1 in femaleStudents)
            {
                student1.Print();
            }
        }
        public void GetMaleStudent()
        {
            Console.WriteLine("Male students are:");
            IEnumerable<Student> maleStudents = from student in students where student.Gender.Equals("male") select student;
            foreach (Student student1 in maleStudents)
            {
                student1.Print();
            }
        }
        public void GetStudentsFromBeijingTech()
        {
            Console.WriteLine("The students from Beijing Tech are: ");

            IEnumerable<Student> beijingStudents = from student in students
                                                   join university in universities on student.UniversityID equals (university.Id)
                                                   where university.Name.Equals("Beijing Tech") 
                                                   select student;

            foreach (Student student in beijingStudents)
            {
                student.Print();
            }

        }
        public void GetAllStudentFromThatUni(string uniName )
        {
            Console.WriteLine("The students from {0} University are:",uniName);
            IEnumerable<Student> studentsInThatUni = from student in students
                                                     join university in universities on student.UniversityID equals university.Id
                                                     where university.Name.Equals(uniName) select student ;
            foreach (Student student in studentsInThatUni)
            {
                student.Print() ;
            }
        }
        public IEnumerable<Student>  SortStudentsByAge()
        {
            IEnumerable<Student> sortedStudentbyAge = from student in students orderby student.Age ascending select student;
            return sortedStudentbyAge;
        }
    }
}
