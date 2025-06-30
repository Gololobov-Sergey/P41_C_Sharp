using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P41_C_Sharp
{
    internal class Point2D
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Print()
        {
            Console.WriteLine($"X = {X}, Y = {Y}");
        }

        public static Point2D operator-(Point2D point)
        {
            return new Point2D { X = -point.X, Y = -point.Y };
        }

        public static Point2D operator --(Point2D point)
        {
            point.X--;
            point.Y--;
            return point;
        }

        public static Point2D operator ++(Point2D point)
        {
            point.X++;
            point.Y++;
            return point;
        }

        public static Point2D operator +(Point2D point1, Point2D point2)
        {
            return new Point2D { X =  point1.X + point2.X, Y = point1.Y + point2.Y };
        }

        public static Point2D operator +(Point2D point1, int number)
        {
            return new Point2D { X = point1.X + number, Y = point1.Y + number };
        }

        public static Point2D operator +(int number, Point2D point1)
        {
            return point1 + number; 
        }

        public static bool operator==(Point2D point1, Point2D point2)
        {
            return point1.X == point2.X && point1.Y == point2.Y;
        }

        public static bool operator !=(Point2D point1, Point2D point2)
        {
            return point1.X != point2.X || point1.Y != point2.Y;
        }

        public static bool operator > (Point2D point1, Point2D point2)
        {
            return Math.Sqrt(point1.X * point1.X + point1.Y * point1.Y) >
                   Math.Sqrt(point2.X * point2.X + point2.Y * point2.Y);
        }

        public static bool operator < (Point2D point1, Point2D point2)
        {
            return Math.Sqrt(point1.X * point1.X + point1.Y * point1.Y) <
                   Math.Sqrt(point2.X * point2.X + point2.Y * point2.Y);
        }


        public static bool operator true(Point2D point)
        {
            return point.X != 0 || point.Y != 0;
        }

        public static bool operator false(Point2D point)
        {
            return point.X == 0 && point.Y == 0;
        }


        public static Point2D operator |(Point2D point1, Point2D point2)
        {
            return new Point2D { X = point1.X | point2.X, Y = point1.Y | point2.Y };
        }

        public static Point2D operator &(Point2D point1, Point2D point2)
        {
            return new Point2D { X = point1.X & point2.X, Y = point1.Y & point2.Y };
        }


        public static implicit /*explicit*/ operator float(Point2D point)
        {
            return (float)Math.Sqrt(point.X * point.X + point.Y * point.Y);
        }

        public static implicit /*explicit*/ operator int(Point2D point)
        {
            return (int)Math.Sqrt(point.X * point.X + point.Y * point.Y);
        }

        public static /*implicit*/ explicit operator Apple(Point2D point)
        {
            return new Apple
            {
                Radius = point.X + point.Y,
                Color = point.X > point.Y ? ConsoleColor.Red : ConsoleColor.Green
            };
        }


        public int this[int index]
        {
            get
            {
                if (index == 0) return X;
                if (index == 1) return Y;
                throw new IndexOutOfRangeException("Index must be 0 or 1.");
            }
            set
            {
                if (index == 0) X = value;
                else if (index == 1) Y = value;
                else throw new IndexOutOfRangeException("Index must be 0 or 1.");
            }
        }

        public int this[string index]
        {
            get
            {
                if (index == "0") return X;
                if (index == "1") return Y;
                throw new IndexOutOfRangeException("Index must be 0 or 1.");
            }
            set
            {
                if (index == "0") X = value;
                else if (index == "1") Y = value;
                else throw new IndexOutOfRangeException("Index must be 0 or 1.");
            }
        }
    }
}
