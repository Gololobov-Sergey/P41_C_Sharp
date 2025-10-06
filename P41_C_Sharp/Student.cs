using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P41_C_Sharp
{
   
    public class StudentCard : IComparable<StudentCard>, ICloneable
    {
        public string? Series { get; set; }

        public int Number { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(StudentCard? sc)
        {
            return (Series + Number.ToString()).CompareTo(sc!.Series + sc!.Number.ToString());
        }

        public override string ToString()
        {
            return $"{Series} {Number}";
        }
    }

    [Programmer]
    public class Student : IComparable<Student>, ICloneable
    {
        int id = 99;

        [Programmer]
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public DateTime BirthDay { get; set; }
        public StudentCard? StudentCard { get; set; }

        public static IComparer FromBirthDay { get; } = new DateComparer();

        public static IComparer FromStudentCard { get; } = new StudentCardComparer();


        [Programmer("Pupkin V.V", "2025.10.01")]
        public int CompareTo(Student? st)
        {

            if(st != null)
                return (LastName + FirstName).CompareTo(st.LastName + st.FirstName);

            throw new NullReferenceException("Некорректное преобразование типов");
        }

        public override string ToString()
        {
            return $"{LastName,-10} {FirstName,-8} {BirthDay.ToShortDateString()} {StudentCard}";
        }

        public object Clone()
        {
            Student temp = (Student)this.MemberwiseClone();
            temp.StudentCard = new StudentCard { Series = this.StudentCard!.Series, Number = this.StudentCard!.Number };
            return temp;
        }

        public override int GetHashCode()
        {
            return (LastName + FirstName).GetHashCode();
        }

        // #1
        public void Exam(string date)
        {
            Console.WriteLine($"{LastName} {FirstName} назначено екзамен на {date}");
        }


        public void Exam(object? sender, ExamEventArgs args)
        {
            Teacher t = sender as Teacher;
            Console.WriteLine($"{t.Name} назначив екзамен для {LastName} {FirstName} по предмету {args.Subject} на {args.Date} в аудитории {args.Room}");
        }
    }

    class Group : IEnumerable
    {
        Student[] students;
        
        public Group()
        {
            students = new Student[4]
            {
                new Student { LastName="Sidorov", FirstName="Ivan",   BirthDay=new DateTime(2000,10,5), StudentCard=new StudentCard { Series="AC", Number=123456 } },
                new Student { LastName="Ivanova", FirstName="Maria",  BirthDay=new DateTime(2000,10,3), StudentCard=new StudentCard { Series="AB", Number=123455 } },
                new Student { LastName="Ivanov",  FirstName="Sidr",   BirthDay=new DateTime(2002,3,3),  StudentCard=new StudentCard { Series="AA", Number=123456 } },
                new Student { LastName="Smirnov", FirstName="Sergey", BirthDay=new DateTime(1999,4,4),  StudentCard=new StudentCard { Series="AB", Number=123466 } }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return students.GetEnumerator();
        }




        public void Sort()
        {
            Array.Sort(students);
        }


        public void Sort(IComparer comparer)
        {
            Array.Sort(students, comparer);
        }
    }



    class DateComparer : IComparer
    {
        public int Compare(object? st1, object? st2)
        {
            Student? s1 = st1 as Student;
            Student? s2 = st2 as Student;
            return DateTime.Compare(s1!.BirthDay, s2!.BirthDay);
        }
    }


    class StudentCardComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Student? st1 = x as Student;
            Student? st2 = y as Student;
            return st1!.StudentCard!.CompareTo(st2!.StudentCard);
        }
    }


    public delegate void ExamDelegate(string date);

    class Teacher
    {

        public string Name { get; set; }

        // #1

        SortedList<string, ExamDelegate> examDelegates = new SortedList<string, ExamDelegate>();

        public event ExamDelegate ExamEvent
        {
            add 
            {
                Student student = value.Target as Student;
                examDelegates.Add(student.LastName+student.FirstName, value);
            }

            remove 
            {
                Student student = value.Target as Student;
                examDelegates.Remove(student.LastName + student.FirstName);
            }
        }


        public void SetExam(string date)
        {
            foreach (var item in examDelegates.Keys)
            {
                if (examDelegates[item] != null)
                    examDelegates[item](date);
            }
        }


        //public EventHandler<ExamEventArgs>? ExamEvent;

        //public void SetExam(string date, string subject, int room)
        //{
        //    ExamEventArgs args = new ExamEventArgs { Date = date, Subject = subject, Room = room };
        //    if (ExamEvent != null)
        //        ExamEvent(this, args);
        //}

    }



    public class ExamEventArgs : EventArgs
    {
        public string? Date { get; set; }

        public string Subject { get; set; }

        public int Room { get; set; }
    }

}
