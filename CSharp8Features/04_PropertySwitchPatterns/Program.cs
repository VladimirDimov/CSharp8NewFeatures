using System;

namespace _04_PropertySwitchPatterns
{
    class Program
    {
        static void Main()
        {
            var state = new State { Code = "NY" };

            Console.WriteLine("Average Salary = " + GetStateAverageSalary(state));
        }

        private static decimal GetStateAverageSalary(State state)
        {
            return state switch
            {
                { Code: "NY" } => 3000m,
                { Code: "NJ" } => 2500m,
                _ => throw new ArgumentException("Invalid state"),
            };
        }
    }
}
