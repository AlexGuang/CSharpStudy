using System;
using System.Linq;
using System.Threading;

namespace ThreadPoolThreadInBackgroud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("sdfsdfsd");
            //new Thread(() =>
            //{
            //    Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} starts.");
            //    Thread.Sleep(1000);
            //    Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} ends.");
            //})
            //{ IsBackground = true }.Start();
            Enumerable.Range(0, 1000).ToList().ForEach(f =>

            {
                 ThreadPool.QueueUserWorkItem((o) =>
                 {
                     Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} starts.");
                     Thread.Sleep(1000);
                     Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} ends.");
                 }) ;
  
            });
        }
    }
}
