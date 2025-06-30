using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace P41_C_Sharp
{
    internal class Apple
    {
        public int Radius { get; set; }

        public ConsoleColor Color { get; set; }


        public static Kompot operator +(Apple a, Apple b)
        {
            return new Kompot
            {
                Apples = new Apple[] { a, b }
            };  
        }
    }


    internal class Kompot
    {
        public Apple[] Apples { get; set; }

        string[] ingradients;

        public static Kompot operator +(Kompot k, Apple a)
        {
            if (k.Apples == null)
            {
                k.Apples = new Apple[] { a };
            }
            else
            {
                var apples = new Apple[k.Apples.Length + 1];
                Array.Copy(k.Apples, apples, k.Apples.Length);
                apples[apples.Length - 1] = a;
                k.Apples = apples;
            }
            return k;
        }

        public static Kompot operator +(Kompot k, string ingradient)
        {
            if (k.ingradients == null)
            {
                k.ingradients = new string[] { ingradient };
            }
            else
            {
                var ingradients = new string[k.ingradients.Length + 1];
                Array.Copy(k.ingradients, ingradients, k.ingradients.Length);
                ingradients[ingradients.Length - 1] = ingradient;
                k.ingradients = ingradients;
            }
            return k;
        }

        public void Print()
        {
            Console.WriteLine("Kompot contains:");
            if (Apples != null)
            {
                foreach (var apple in Apples)
                {
                    Console.WriteLine($"Apple with radius {apple.Radius} and color {apple.Color}");
                }
            }
            else
            {
                Console.WriteLine("No apples in kompot.");
            }
            if (ingradients != null)
            {
                Console.WriteLine("Ingradients:");
                foreach (var ingradient in ingradients)
                {
                    Console.WriteLine(ingradient);
                }
            }
            else
            {
                Console.WriteLine("No ingradients in kompot.");
            }
        }
    }
}


