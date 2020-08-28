using System;

namespace _02_DefaultInterfaceMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson person = new Person
            {
                Name = "Pesho",
                BirthDate = new DateTime(1984, 11, 24),
            };

            Console.WriteLine(person.DaysToBirthday());
        }
    }
}
