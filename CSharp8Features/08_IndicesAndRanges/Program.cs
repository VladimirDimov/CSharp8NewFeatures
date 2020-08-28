using System;

namespace _08_IndicesAndRanges
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new string[]
            {
                            // index from start    index from end
                "The",      // 0                   ^9
                "quick",    // 1                   ^8
                "brown",    // 2                   ^7
                "fox",      // 3                   ^6
                "jumped",   // 4                   ^5
                "over",     // 5                   ^4
                "the",      // 6                   ^3
                "lazy",     // 7                   ^2
                "dog"       // 8                   ^1
            };              // 9 (or words.Length) ^0

            Console.WriteLine($"words[^1] = {words[^1]}"); // words[^1] = dog

            Console.WriteLine($"words[0..3] = {string.Join(", ", words[0..3])}");// words[0..3] = The, quick, brown

            Console.WriteLine($"words[^2..^0] = {string.Join(", ", words[^2..^0])}");// words[^2..^0] = lazy, dog

            Console.WriteLine($"words[..] = {string.Join(", ", words[..])}");// words[..] = The, quick, brown, fox, jumped, over, the, lazy, dog

            Console.WriteLine($"words[..2] = {string.Join(", ", words[..2])}");// words[..2] = The, quick

            Console.WriteLine($"words[2..] = {string.Join(", ", words[2..])}");// words[2..] = brown, fox, jumped, over, the, lazy, dog

            Console.WriteLine($"1..5 = {string.Join(", ", 1..5)}");// words[2..] = brown, fox, jumped, over, the, lazy, dog
        }
    }
}
