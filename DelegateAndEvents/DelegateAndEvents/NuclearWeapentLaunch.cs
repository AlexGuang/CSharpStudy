using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DelegateAndEvents
{
    internal class NuclearWeapentLaunch
    {
        public void OnVideoEncoded(object o, EventArgs eventArgs)
        {
            Console.WriteLine("Press the RED button");
            Console.ReadKey();
            
            Thread.Sleep(2000);
            Console.WriteLine("Nuclear Weapent Launching process inilizing completed 5%,");
            Thread.Sleep(2000);
            Console.WriteLine("Nuclear Weapent Launching process inilizing completed 20%,");
            Thread.Sleep(2000);
            Console.WriteLine("Nuclear Weapent Launching process inilizing completed 50%,");
            Thread.Sleep(2000);
            Console.WriteLine("Nuclear Weapent Launching process inilizing completed 80%,");
            Thread.Sleep(2000);
            Console.WriteLine("Nuclear Weapent Launching process inilizing completed 100%,");
            Console.WriteLine("Nuclear Weapent Launching process inilizing complete, the last 10 seconds begin:");
            Thread.Sleep(1000);
            Console.WriteLine("10");
            Thread.Sleep(1000);
            Console.WriteLine("9");
            Thread.Sleep(1000);
            Console.WriteLine("8");
            Thread.Sleep(1000);
            Console.WriteLine("7");
            Thread.Sleep(1000);
            Console.WriteLine("6");
            Thread.Sleep(1000);
            Console.WriteLine("5");
            Thread.Sleep(1000);
            Console.WriteLine("4");
            Thread.Sleep(1000);
            Console.WriteLine("3");
            Thread.Sleep(1000);
            Console.WriteLine("2");
            Thread.Sleep(1000);
            Console.WriteLine("1");


            Console.WriteLine(" A Nuclear Weapent has launched!");
            Console.WriteLine(" The End of the world has come!");
        }
    }
}
