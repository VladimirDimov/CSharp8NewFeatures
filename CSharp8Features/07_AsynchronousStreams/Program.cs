using System;
using System.Threading;

namespace _07_AsynchronousStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            var runner = new Runner();
            runner.Do();

            Console.WriteLine("Main Thread: " + Thread.CurrentThread.ManagedThreadId);
            Console.ReadLine();
        }
    }
}
