using System;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Linq_with_XML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //We simply apply our Student-Structure to XML.
            string studentsXML =
                            @"<Students>
                                <Student>
                                    <Name>Toni</Name>
                                    <Age>21</Age>
                                    <University>Yale</University>
                                    <Semester>6</Semester>
                                </Student>
                                <Student>
                                    <Name>Carla</Name>
                                    <Age>17</Age>
                                    <University>Cambridge</University>
                                    <Semester>1</Semester>
                                </Student>
                                <Student>
                                    <Name>Lydia</Name>
                                    <Age>19</Age>
                                    <University>Beijing Tech</University>
                                    <Semester>3</Semester>
                                </Student>
                                <Student>
                                    <Name>Frank</Name>
                                    <Age>25</Age>
                                    <University>Stanford</University>
                                    <Semester>12</Semester>
                                </Student>
                             </Students>";
            XDocument xd = new XDocument();

            xd = XDocument.Parse(studentsXML);
            var students = from student in xd.Descendants("Student")
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = student.Element("Age").Value,
                               University = student.Element("University").Value,
                               Semester = student.Element("Semester").Value
                           };
            foreach (var student in students)
            {
                Console.WriteLine("{0}, aged {1}, is studying at {2} university in {3} Semester.",student.Name,student.Age,student.University,student.Semester);
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("sorted students:");// Sort the students by age:
            var sortedStudent = from student in (from student in xd.Descendants("Student")// can be students
                                                 select new
                                                 {
                                                     Name = student.Element("Name").Value,
                                                     Age = student.Element("Age").Value,
                                                     University = student.Element("University").Value
                                                 })orderby student.Age ascending select student;

            foreach (var student in sortedStudent)
            {
                Console.WriteLine("{0}, aged {1}, is studying at {2} university", student.Name, student.Age, student.University);
            }
        }
    }
}
