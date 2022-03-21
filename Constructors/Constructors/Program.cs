using System;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human olivia =new Human();
            Human xiaoguang = new Human("xiaoguang");
            Human alex = new Human("alex", "li");
            olivia.IntroduceMyself();
            xiaoguang.IntroduceMyself();
            alex.IntroduceMyself();

            Human jack = new Human("Jack", "Sun", "black", 18);
           jack.IntroduceMyself();
        }
    }
}
