

using System.Text;

namespace P41_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "P41 C#";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Clear();



            /*int sum = 0;
            int product = 1;
            int max = Int32.MinValue;
            int min = Int32.MaxValue;

            int count = 5;
            for (int i = 0; i < count; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());

                sum += num;
                product *= num;

                max = Int32.Max(max, num);  
                min = Int32.Min(min, num);
            }

            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Prod = {product}");*/




            int num = Convert.ToInt32(Console.ReadLine());


            int? s = null;



            //int a = 5;
            //if (a == 0)
            //{

            //}
            //else
            //{

            //}


            //Console.WriteLine($"a = {a}");

            //switch (a)
            //{
            //    case 1:
            //    case 0:
            //        Console.WriteLine(0);
            //        break;

            //    default:
            //        break;
            //}


            //string s = a switch
            //{
            //    1 => "mama",
            //    2 => "papa",
            //    _ => "default"
            //};

            //string c = a == 0 ? "mama" : "baba";


            //for (int i = 0; i < 10; i++)
            //{

            //}

            //while (true)
            //{

            //}

            //do
            //{

            //} while (a == 0);
        }
    }
}
