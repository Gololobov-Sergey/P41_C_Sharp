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

        public static bool operator <(Point2D point1, Point2D point2)
        {
            return Math.Sqrt(point1.X * point1.X + point1.Y * point1.Y) <
                   Math.Sqrt(point2.X * point2.X + point2.Y * point2.Y);
        }

    }
}
