using System;
using System.Threading;

namespace Creating_Thread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            new Thread(() => {

                Thread.Sleep(1000);
                Console.WriteLine("Thread 1");
                
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 2");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 3");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 4");
            }).Start();
            //The four threads begin at same time,so order of print can be random.
        }
    }
}
