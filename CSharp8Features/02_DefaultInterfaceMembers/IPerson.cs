using System;

namespace _02_DefaultInterfaceMembers
{
    public interface IPerson
    {
        string Name { get; set; }

        DateTime BirthDate { get; set; }

        public double DaysToBirthday()
        {
            double daysToBirthday = (new DateTime(DateTime.Now.Year, BirthDate.Month, BirthDate.Day) - DateTime.Now).TotalDays;

            return Math.Round(daysToBirthday, 1);
        }
    }
}