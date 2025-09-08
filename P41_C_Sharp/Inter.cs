using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P41_C_Sharp
{
    interface IA
    {
        string A1(int n);
    }

    interface IB
    {
        string B1();

        void B2(int n);
    }

    interface IC : IA, IB
    {
        void C1();
    }

    class Inter : IC
    {
        public string A1(int n)
        {
            return $"A1: {n}";
        }
        public string B1()
        {
            return "B1";
        }
        public void B2(int n)
        {
            Console.WriteLine($"B2: {n}");
        }
        public void C1()
        {
            Console.WriteLine("C1");
        }
    }

    interface ICC
    {
        void Show();
        ////
        ///
    }

    interface IAA
    {
        void Show();
        ////
        ///

    }

    interface IBB
    {
        void Show();
        ////
        ///
    }





    class Inter2 : IAA, IBB, ICC
    {
        void ICC.Show()
        {
            Console.WriteLine("Show C");
        }
        void IAA.Show()
        {
            Console.WriteLine("Show A");
        }

        void IBB.Show()
        {
            Console.WriteLine("Show B");
        }
    }
}
