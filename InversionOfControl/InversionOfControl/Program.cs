using System;

namespace InversionOfControl
{
    /*
         本节内容：DI（Dependency Injection） -IOC(Inversion of Control)-- 依赖倒置原则（效果）
         
         依赖倒置原则：
        1.上层模块不应该依赖底层模块，它们都应该依赖于抽象
        2.抽象不应该依赖于细节，细节应该依赖于抽象
         
         */
    internal class Program
    {
        
        static void Main(string[] args)
        {
           IocShow iocShow = new IocShow();
           iocShow.Show();
            Console.WriteLine("hello world");
        }
    }
}
