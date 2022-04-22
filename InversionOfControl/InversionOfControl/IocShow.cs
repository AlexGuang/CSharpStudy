using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfControl
{
    /*
        本节内容：DI（Dependency Injection） -IOC(Inversion of Control)-- 依赖倒置原则（效果）

        依赖倒置原则：
       1.上层模块不应该依赖底层模块，它们都应该依赖于抽象
       2.抽象不应该依赖于细节，细节应该依赖于抽象

        */
    internal class IocShow
    {
        public void Show()
        {
            //Student student = new Student();

            IPerson person = Factory.CreateInstance();
            person.PlayGame();
        }


    }
    class Factory
    {
        public static IPerson CreateInstance()
        {
            return new Teacher(CreateMessage());
        }
        public static IMessage CreateMessage()
        {
            return new Message();
        }
    }

    interface IPerson
    {
        void PlayGame();

    }

    class Student : IPerson
    {
        public void PlayGame()
        {
            Console.WriteLine("我是小明同学，我在玩游戏");
        }
    }
    class Teacher : IPerson
    {
        private IMessage _message;
        public Teacher(IMessage message)
        {
            _message = message;
        }
        public void PlayGame()
        {
            // IMessage message = Factory.CreateMessage();
            _message.SendMessage("帅哥", "成功");
            Console.WriteLine("我是sky老师，我在工作");
        }
    }

    interface IMessage
    {
        void SendMessage(string person, string message);
    }

    class Message : IMessage
    {
        public void SendMessage(string person, string message)
        {
            Console.WriteLine($"{person}+{message}");
        }
    }
}
