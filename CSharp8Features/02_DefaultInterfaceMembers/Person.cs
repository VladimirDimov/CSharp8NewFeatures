using System;

namespace _02_DefaultInterfaceMembers
{
    public class Person : IPerson
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
