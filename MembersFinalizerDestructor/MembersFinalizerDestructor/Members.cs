using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersFinalizerDestructor
{
    internal class Members
    {
        private string memberName;
        private string jobTitle;

        public int age;
        private int salary;
        public bool IsFriend { get; set; }
        public int Salary
        {

            get
            {
                if (IsFriend)
                {
                    return salary;
                }
                else
                    return 0;
            }
            set
            {
                salary = value;
            } }
        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }
        public Members(string memberName, string jobTitle, int age)
        {
            this.memberName = memberName;
            this.jobTitle = jobTitle;
            this.age = age;

            Console.WriteLine("Instance created");
        }
        public void IntroduceTheMember()
        {
            if (IsFriend)
            {
                ShowPrivateInfo();

            }
            else
            {
                Console.WriteLine("The member's name is {0},job is {1}, age is {2}",memberName,JobTitle,age);
            }
        }
        private void ShowPrivateInfo()
        {
            Console.WriteLine("My,friend, my salary is: {0}",Salary);
        }

        ~Members()
        {
            Console.WriteLine("Instance finalized");
        }
    }
}
