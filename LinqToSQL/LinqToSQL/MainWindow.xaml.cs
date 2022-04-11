using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;

namespace LinqToSQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LinqToSQLDaterSeterDataContext linqToSQLDaterSeterDataContext;
        
        public MainWindow()
        {
            InitializeComponent();

            string connectString = ConfigurationManager.ConnectionStrings["LinqToSQL.Properties.Settings.XiaoguangDBConnectionString"].ConnectionString;
            linqToSQLDaterSeterDataContext = new LinqToSQLDaterSeterDataContext(connectString);
            //   InsertUniversities();
            //InsertStudents();
            //  InsertLectures();
            //InsertStudentLectureAssociations();
            //GetLectrureOfStudent("Candy");
            GetUniversityOfStudent("Jeams");



        }

        public void InsertYaleUniversitis()
        {
           // linqToSQLDaterSeterDataContext.ExecuteCommand("delete from University");
            //linqToSQLDaterSeterDataContext.ExecuteCommand("SET IDENTITY_INSERT University ON");
            University yale = new University();

            yale.Name = "Yale";
            yale.RankedNum = 20;
            yale.Country = "USA";
            yale.Location = "Decosasos";

            linqToSQLDaterSeterDataContext.Universities.InsertOnSubmit(yale);
            linqToSQLDaterSeterDataContext.SubmitChanges();
            linqToSQLDaterSeterDataContext.ExecuteCommand("SET IDENTITY_INSERT University OFF");
           // MainDataGrid.ItemsSource = linqToSQLDaterSeterDataContext.Universities;
        }
        //public void InsertStudents2()
        //{
        //    Student xiaoming = new Student();
        //    xiaoming.Name = "小明";
        //    xiaoming.Age = 20;
        //    xiaoming.Gender = "Male";
        //    xiaoming.UniversityId = 0;

        //    linqToSQLDaterSeterDataContext.Students.InsertOnSubmit(xiaoming);
        //    linqToSQLDaterSeterDataContext.SubmitChanges();

        //    MainDataGrid.ItemsSource = linqToSQLDaterSeterDataContext.Students;
        //}
        /// <summary>
        /// Insert an object into the database
        /// </summary>
        public void InsertUniversities()
        {
            University university = new University();// Create a new object

            university.Name = "Tasmania University";
            university.Country = "Australia";
            university.RankedNum = 186;
            university.Location = "Tasmania";   // Initialize the object


            University university1 = new University();
            university1.Name = "Beijing Tech";
            university1.RankedNum = 24;
            university1.Country = "China";
            university1.Location = "Beijing";


            linqToSQLDaterSeterDataContext.Universities.InsertOnSubmit(university);
            linqToSQLDaterSeterDataContext.Universities.InsertOnSubmit(university1);// Submit the object to datacontext

            linqToSQLDaterSeterDataContext.SubmitChanges(); // Submit the datacontext to database

            MainDataGrid.ItemsSource = linqToSQLDaterSeterDataContext.Universities; // Show the database in app

        }

        public void InsertStudents()
        {
            University yale = linqToSQLDaterSeterDataContext.Universities.First(( un => un.Name == "Yale"));
            University beijingTech = linqToSQLDaterSeterDataContext.Universities.First(un => un.Name == "Beijing Tech");
            University tasmania = linqToSQLDaterSeterDataContext.Universities.First( un => un.Name == "Tasmania University");

            List<Student> students = new List<Student>();
            students.Add(new Student { Name = "Candy", Age = 19, Gender = "female", University = beijingTech });
            students.Add(new Student { Name = "Frank", Age = 22, Gender = "male", UniversityId = 4 });
            students.Add(new Student { Name = "Joe", Age = 18, Gender = "male", University = beijingTech });
            students.Add(new Student { Name = "Micheal", Age = 17, Gender = "male", UniversityId = 9 });
            students.Add(new Student { Name = "Marry", Age = 20, Gender = "female", UniversityId = 5 });
            students.Add(new Student { Name = "Lydia", Age = 21, Gender = "female", University = tasmania });
            students.Add(new Student { Name = "Jeams", Age = 19, Gender = "male", UniversityId = 9 });
            students.Add(new Student { Name = "Mick", Age = 22, Gender = "male", UniversityId = 6 });
            students.Add(new Student { Name = "Lorua", Age = 17, Gender = "female", University = beijingTech});



            linqToSQLDaterSeterDataContext.Students.InsertAllOnSubmit(students); // Insert objects to the data context
            linqToSQLDaterSeterDataContext.SubmitChanges();// Upload the datacontext to database

            MainDataGrid.ItemsSource = linqToSQLDaterSeterDataContext.Students;// Show the updated database on the application
        }


        public void InsertLectures()
        {
            Lecture lecture =  new Lecture();
            lecture.Name = "Big Data and Algorithm";
            lecture.LecturerName = "Tom";
            lecture.ClassRoom = "Room 3, Build 5";


            linqToSQLDaterSeterDataContext.Lectures.InsertOnSubmit(lecture);
           


            linqToSQLDaterSeterDataContext.Lectures.InsertOnSubmit(new Lecture
            { Name = "Object Oriented Programming", LecturerName = "Luke", ClassRoom = "Room 5,Bulid 2" });
            linqToSQLDaterSeterDataContext.Lectures.InsertOnSubmit(new Lecture
            { Name = "Block Chain", LecturerName = "Andison", ClassRoom = "Room 12,Bulid 1" });
            linqToSQLDaterSeterDataContext.Lectures.InsertOnSubmit(new Lecture
            { Name = "Artificial Intelligence", LecturerName = "Taylor", ClassRoom = "Room 9,Bulid 3" });

            linqToSQLDaterSeterDataContext.SubmitChanges(); 

            MainDataGrid.ItemsSource = linqToSQLDaterSeterDataContext.Lectures;

        }
        public void InsertStudentLectureAssociations()
        {
            Student candy = linqToSQLDaterSeterDataContext.Students.First(st => st.Name == "Candy");
            Student frank = linqToSQLDaterSeterDataContext.Students.First(st => st.Name == "Frank");
            Student joe = linqToSQLDaterSeterDataContext.Students.First(st => st.Name == "Joe");
            Student micheal = linqToSQLDaterSeterDataContext.Students.First(st => st.Name == "Micheal");
            Student marry = linqToSQLDaterSeterDataContext.Students.First(st => st.Name == "Marry");
            Student lydia = linqToSQLDaterSeterDataContext.Students.First(st => st.Name == "Lydia");
            Student jeams = linqToSQLDaterSeterDataContext.Students.First(st => st.Name == "Jeams");
            Student lorua = linqToSQLDaterSeterDataContext.Students.First(st => st.Name == "Lorua");
            Student mick = linqToSQLDaterSeterDataContext.Students.First(st => st.Name == "Mick");

            Lecture bigData = linqToSQLDaterSeterDataContext.Lectures.First(lec => lec.Name == "Big Data and Algorithm");
            Lecture objectoriented = linqToSQLDaterSeterDataContext.Lectures.First(lec => lec.Name == "Object Oriented Programming");
            Lecture blockChain = linqToSQLDaterSeterDataContext.Lectures.First(lec => lec.Name == "Block Chain");
            Lecture artificialIntelligence = linqToSQLDaterSeterDataContext.Lectures.First(lec => lec.Name == "Artificial Intelligence");

            linqToSQLDaterSeterDataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = candy.Id, LectureId = bigData.Id });
            linqToSQLDaterSeterDataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = jeams.Id, Lecture = objectoriented });
            linqToSQLDaterSeterDataContext.StudentLectures.InsertOnSubmit(new StudentLecture {Student = lydia, Lecture = objectoriented});
            linqToSQLDaterSeterDataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = frank.Id, LectureId = bigData.Id });
            linqToSQLDaterSeterDataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = candy.Id, Lecture = blockChain });
            linqToSQLDaterSeterDataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = mick.Id, LectureId = artificialIntelligence.Id });
            linqToSQLDaterSeterDataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = lorua.Id, Lecture = objectoriented });
            linqToSQLDaterSeterDataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = joe.Id, LectureId = artificialIntelligence.Id });
            linqToSQLDaterSeterDataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = candy.Id, Lecture = blockChain });
            linqToSQLDaterSeterDataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = mick.Id, LectureId = bigData.Id });
            linqToSQLDaterSeterDataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = frank.Id, Lecture = objectoriented });
            linqToSQLDaterSeterDataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = lorua.Id, LectureId = bigData.Id });
            linqToSQLDaterSeterDataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = candy.Id, Lecture = blockChain });
            linqToSQLDaterSeterDataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = marry.Id, LectureId = artificialIntelligence.Id });
            linqToSQLDaterSeterDataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = joe.Id, Lecture = objectoriented });
            linqToSQLDaterSeterDataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = mick.Id, LectureId = bigData.Id });
            linqToSQLDaterSeterDataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = candy.Id, LectureId = bigData.Id });
            linqToSQLDaterSeterDataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = lorua.Id, Lecture = blockChain });
            linqToSQLDaterSeterDataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = candy.Id, LectureId = bigData.Id });
            linqToSQLDaterSeterDataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = mick.Id, Lecture = objectoriented });
            linqToSQLDaterSeterDataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = lorua.Id, LectureId = artificialIntelligence.Id });
            linqToSQLDaterSeterDataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = candy.Id, LectureId = bigData.Id });
            linqToSQLDaterSeterDataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = frank.Id, Lecture = objectoriented });
            linqToSQLDaterSeterDataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = candy.Id, LectureId = bigData.Id });
            linqToSQLDaterSeterDataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = micheal.Id, Lecture = blockChain });
            linqToSQLDaterSeterDataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = lorua.Id, Lecture = objectoriented });
            linqToSQLDaterSeterDataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = candy.Id, LectureId = artificialIntelligence.Id });
            linqToSQLDaterSeterDataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = frank.Id, Lecture = blockChain });


            linqToSQLDaterSeterDataContext.SubmitChanges();
            MainDataGrid.ItemsSource = linqToSQLDaterSeterDataContext.StudentLectures;

        }
        public void GetUniversityOfStudent(string name )
        {
            try
            {
                Student student = linqToSQLDaterSeterDataContext.Students.First(st => st.Name == name);
                University university = student.University;
                List<University> universities = new List<University>();
                universities.Add(university);

                MainDataGrid.ItemsSource = universities;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public void GetLectrureOfStudent(string name)
        {
            try
            {
                Student student = linqToSQLDaterSeterDataContext.Students.First(st => st.Name == name);
                var lecturesOfStudent = from ls in student.StudentLectures select ls.Lecture;

                MainDataGrid.ItemsSource = lecturesOfStudent;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
