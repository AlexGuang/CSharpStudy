using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityManagerUseLinq
{
    internal class Program
    {
        static void Main()
        {
            UniversityManager universityManager = new UniversityManager();

            universityManager.GetMaleStudent();
            universityManager.GetFemaleStudent();
            universityManager.GetStudentsFromBeijingTech();
            universityManager.GetAllStudentFromThatUni("Beijing Tech");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Sort students by age are:");

            foreach (Student item in universityManager.SortStudentsByAge())
            {
                item.Print();
            }

            int[] someInts = { 20, 12, 3, 4, 53, 5, 6, 7, 8, 9, 76 };
            Console.WriteLine("-------------------------------------------------");

            IEnumerable<int> sortedInt = from i in someInts orderby i select i;
            foreach (int i in sortedInt)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------------------------------------------");
            IEnumerable<int> reSortedInt = sortedInt.Reverse();
            foreach (int i in reSortedInt)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------------------------------------------");

            IEnumerable<int> sortedDInt = from i in someInts orderby i descending select i;
            foreach (int i in sortedDInt)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine("New Collection:");
            universityManager.StudentAndUniversityNameCollection();
            

        }
    }
}
