using System;
using System.Collections;
namespace HashTableLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentTable = new Hashtable();

            Student student1 = new Student( 1, "Marry", 84);
            Student student2 = new Student(2, "Jackey", 93);
            Student student3 = new Student(3, "Machiel", 83);

            studentTable.Add(student1.id, student1);
            studentTable.Add(student2.id, student2);
            studentTable.Add(student3.id, student3);

            Student storedStudent = (Student)studentTable[student1.id];
            Console.WriteLine("id:{0}, name:{1}, GPA:{2}",storedStudent.id,storedStudent.name,storedStudent.GPA);
            
            Console.WriteLine("采用DictionaryEntry 作为元素变量类型");
            foreach (DictionaryEntry entry in studentTable)
            {
                Student tem = (Student)entry.Value;// entry.Value return a object;   DictionaryEntry.Value return a object
                Console.WriteLine("ID is:{0} ", tem.id);
                Console.WriteLine("Name is: {0}", tem.name);
                Console.WriteLine("GPA is:{0} ", tem.GPA);
            }
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("采用class类名作为元素变量类型");
            foreach (Student student in studentTable.Values)
            {
                Console.WriteLine("ID is:{0} ", student.id);
                Console.WriteLine("Name is:{0} ", student.name);
                Console.WriteLine("GPA is:{0} ", student.GPA);
            }
        }
    }
}
