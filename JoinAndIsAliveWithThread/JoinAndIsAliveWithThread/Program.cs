using System;
using System.Threading;

namespace JoinAndIsAliveWithThread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread starts:");
            Thread thread1 = new Thread(Thread1);
            Thread thread2 = new Thread(Thread2);
            thread2.Start();
            thread1.Start();
            if (thread1.Join(1000))
            {
                Console.WriteLine("Thread1 has finished");
            }
            else
            {
                Console.WriteLine("Thread1 has not completed within 1 second");
            }
            thread2.Join();
            Console.WriteLine("Thread2 has done.");
            for (int i = 0; i < 10; i++)
            {
                if (thread1.IsAlive)
                {
                    Console.WriteLine("Thread1 is still working");
                    Thread.Sleep(300);
                }
                else
                {
                    Console.WriteLine("Thread1 has finished");
                }
             
            }
                


            Console.WriteLine("Main Thread ends.");
        }
        public static void Thread1()
        {
            Console.WriteLine("Thread 1 Fuction starts:");
            Thread.Sleep(3000);
            Console.WriteLine("Thread1 Function coming back to calller.");
        }
        public static void Thread2()
        {
            Console.WriteLine("Thread 2 Fuction starts:");
        }
    }
}
