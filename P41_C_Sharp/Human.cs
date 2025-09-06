using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace P41_C_Sharp
{
    internal abstract class Human
    {
        int id;
        int age;
        string name;

        public Human(string n, int a)
        {
            name = n;
            age = a;
        }

        //public virtual void Print()
        //{
        //    Console.WriteLine();
        //}

        public override string ToString()
        {
            return $"Name: {name}, Age: {age}";
        }

        public virtual void Test()
        {

        }

        public abstract void whoAmI();

    }

    /*sealed*/ class Employee : Human
    {
        int id;
        int salary;
        public Employee(string n, int a, int s) : base(n, a)
        {
            salary = s;
        }

        //public override void Print()
        //{
        //    base.Print();
        //    Console.WriteLine($"Salary: {salary}");
        //}

        public override string ToString()
        {
            return base.ToString() + $", Salary: {salary}";
        }

        public override void Test()
        {
            base.Test();
        }

        public override void whoAmI()
        {
            Console.WriteLine("I`m Employee");
        }
    }

    class Manager : Employee
    {
        int id;
        int bonus;
        public Manager(string n, int a, int s, int b) : base(n, a, s)
        {
            bonus = b;
        }
       

        override public string ToString()
        {
            return base.ToString() + $", Bonus: {bonus}";
        }

        override public void whoAmI()
        {
            Console.WriteLine("I`m Manager");
        }
    }
}
