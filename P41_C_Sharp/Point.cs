using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P41_C_Sharp
{
    public partial class Point
    {
        int x;
        int y;

        static int count;

        public const int id = 99;

        public readonly int id_x;

        static Point()
        {
            count = 0;
        }

        public Point()
        {
            id_x = 0;
            x = 0;
            y = 0;
        }
        public Point(int x, int y, int id_x)
        {
            this.id_x = id_x;
            this.x = x;
            this.y = y;
        }

        public void Print()
        {
            Console.WriteLine($"X = {x}, Y = {y}");
        }

        static public int GetCount()
        {
            return count;
        }
    }
}
