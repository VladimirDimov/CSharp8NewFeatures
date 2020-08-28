using System;

namespace _05_TupleSwitchPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum = " + GetSum("one", "two"));
        }

        private static int GetSum(string a, string b)
        {
            return (a, b) switch
            {
                ("one", "two") => 3,
                ("two", "three") => 5,
                _ => throw new ArgumentException();
            };
        }
    }
}
