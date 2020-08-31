using System;
using System.Collections.Generic;

namespace _09_NullCoalescingAssignment
{
    class Program
    {
        private static ICollection<int> collection;

        static void Main(string[] args)
        {
            

            for (int i = 0; i < 10; i++)
            {
                collection ??= new List<int>();
                collection.Add(i);
            }

            Console.WriteLine(string.Join(", ", collection));
        }
    }
}
