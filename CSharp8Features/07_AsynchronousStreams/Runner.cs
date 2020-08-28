using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace _07_AsynchronousStreams
{
    class Runner
    {
        public async void Do()
        {
            var collection = GenerateSequence();
            await foreach (var item in collection)
            {
                Console.WriteLine(item + " " + Thread.CurrentThread.ManagedThreadId);
            }
        }

        public static async IAsyncEnumerable<int> GenerateSequence()
        {
            for (int i = 0; i < 20; i++)
            {
                await Task.Delay(100);
                yield return i;
            }
        }
    }
}
