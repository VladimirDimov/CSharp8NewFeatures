using System;

namespace _03_SwitchExpressions
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(GetNumberAsString(1));
            Console.WriteLine(GetNumberAsString(2));
            Console.WriteLine(GetNumberAsString(3));
            Console.WriteLine(GetNumberAsString(4));
        }

        private static string GetNumberAsString(int number)
        {
            return number switch
            {
                1 => "One",
                2 => "Two",
                3 => "Three",
                _ => throw new ArgumentException("Invalid number"),
            };
        }
    }
}
