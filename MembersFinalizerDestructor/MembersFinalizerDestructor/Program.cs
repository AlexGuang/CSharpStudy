using System;

namespace MembersFinalizerDestructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Members jack = new Members("Jack", "Manager", 32);
            jack.Salary = 2000;
            jack.IsFriend = false;
            jack.IntroduceTheMember();

            Members lucy = new Members("Lucy", "Custmer Manager", 22);
            lucy.Salary = 5000;
        
            lucy.IntroduceTheMember();


            Members alex = new Members("alex", "Tech Manager", 22);
            alex.Salary = 100000;
            alex.IsFriend = true;
            alex.IntroduceTheMember();

        }
    }
}
