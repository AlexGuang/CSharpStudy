using System;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadStartAndEndCompletion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var taskCompletionSource = new TaskCompletionSource<bool>();

            Thread thread = new Thread(() =>
            {
                Console.WriteLine($"Thread:{Thread.CurrentThread.ManagedThreadId}  starts");
                Thread.Sleep(5000);
                taskCompletionSource.TrySetResult(true);
                Console.WriteLine($"Thread:{Thread.CurrentThread.ManagedThreadId} ends");

            });
            thread.Start();
            var text = taskCompletionSource.Task.Result;
            Console.WriteLine("task was done: {0}",text);
        }
    }
}
