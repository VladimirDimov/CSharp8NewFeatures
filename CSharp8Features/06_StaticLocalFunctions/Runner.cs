using System;

namespace _06_StaticLocalFunctions
{
    class Runner
    {
        public void Do()
        {
            int a = 1;
            int b = 2;

            static int sum(int c, int d) => c + d;
            Console.WriteLine(sum(1, 2));

            //static int sum2() => a + b; // This will break the code
        }
    }
}
