using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P41_C_Sharp
{
    internal class BirthDay
    {
        DateOnly birthday;

        public BirthDay(DateOnly dateOfBirth)
        {
            birthday = dateOfBirth;
        }

        public BirthDay(int year, int month, int day)
        {
            birthday = new DateOnly(year, month, day);
        }

        public BirthDay(string dateOfBirth)
        {
            DateOnly.TryParse(dateOfBirth, out birthday);
        }

        public DateOnly GetBirthDay()
        {
            return birthday;
        }

        public DayOfWeek GetDayOfWeek()
        {
            return birthday.DayOfWeek;
        }

        public DayOfWeek GetDayOfWeek(int year)
        {
            DateOnly dayInYear = new DateOnly(DateTime.Now.Year, birthday.Month, birthday.Day);
            var delta = new DateTime(dayInYear, new TimeOnly()) - DateTime.Now;
            if (delta.Days > 0)
            {
                return dayInYear.DayOfWeek;
            }
            else
            {
                return dayInYear.AddYears(1).DayOfWeek;
            }
        }

    }
}
