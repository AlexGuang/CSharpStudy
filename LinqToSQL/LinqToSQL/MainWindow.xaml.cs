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
            InsertUniversities();
         //  InsertStudents();

        }
        public void InsertUniversities()
        {
             //linqToSQLDaterSeterDataContext.ExecuteCommand("delete from University");
            //linqToSQLDaterSeterDataContext.ExecuteCommand("SET IDENTITY_INSERT University ON");
            University yale = new University();
            
            yale.Name = "Yale";
           yale.RankedNum = 20;
            yale.Country = "USA";
            yale.Location = "Decosasos";

            linqToSQLDaterSeterDataContext.Universities.InsertOnSubmit(yale);
            linqToSQLDaterSeterDataContext.SubmitChanges();
           // linqToSQLDaterSeterDataContext.ExecuteCommand("SET IDENTITY_INSERT University OFF");
            MainDataGrid.ItemsSource = linqToSQLDaterSeterDataContext.Universities;
        }
        //public void InsertStudents()
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
    }
}
