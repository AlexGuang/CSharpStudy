using System;

namespace DateTimeT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            DateTime dateTime =new DateTime(2018,02,25);

            Console.WriteLine("My birthday is {0}!",dateTime);

            DateTime dateTime1 = new DateTime(2018);
            Console.WriteLine("My birthday is {0}!", dateTime1);
            //Write today on screen
            Console.WriteLine(DateTime.Today);
            //Write current tiem on screen
            Console.WriteLine(DateTime.Now);

            DateTime dateTime2 = GetTomorrow();
            Console.WriteLine("Tomorrow will be the {0}",dateTime2);

            static DateTime GetTomorrow()
            {
                return DateTime.Today.AddDays(1);
            }

            Console.WriteLine(  "Today is {0}", DateTime.Today.DayOfWeek);*/

            DateTime dateTime3 =  new DateTime(2019,2,19);
            //  Console.WriteLine("The current time is {0}:{1}:{2}",dateTime3.Hour,dateTime3.Minute,dateTime3.Second);
            Console.WriteLine("请输入您的名字:");
            string name = Console.ReadLine();
            Console.WriteLine("现在的时间是：{0}",DateTime.Now);
            Console.WriteLine("请输入您的生日：");
            string input = Console.ReadLine();
            if (DateTime.TryParse(input,out DateTime birthday))
            {
                TimeSpan manydays = dateTime3.Subtract(birthday);
                Console.WriteLine("{1},您已经降临到这个世界上 {0} 天了", manydays.Days,name);
            }
        }
    }
}
