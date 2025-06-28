using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    namespace Functions
    {
        class Func
        {
            public static bool isEven(int a)
            {
                return a % 2 == 0;
            }
        }
    }


    
    class Student
    {
        private string? lastName;

        public string? LastName
        {
            get 
            { 
                return lastName != null ? LastName : "No name";
            }
            set { lastName = value; }
        }

        private string? firstName;

        public string? FirstName
        {
            get { return firstName != null ? firstName : "No name"; }
            set { firstName = value; }
        }

        private DateTime date;

        public DateTime BirthDate
        {
            get { return date; }
            set { date = value; }
        }

        public int Id { get; set; }

    }
}
