

using System.Text;

namespace P41_C_Sharp
{
    internal class Program
    {
        static bool isEven(int a)
        {
            return a % 2 == 0;
        }

        static void Main(string[] args)
        {
            Console.Title = "P41 C#";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Clear();



            // 21.06.2025

            string? str = Console.ReadLine();

            var words = str.Split();
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = new string(words[i].Reverse().ToArray());
            }

            Console.WriteLine(String.Join(' ', words));




            //string st = "mama    papa    baba";
            //var str = st.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //foreach (var item in str)
            //{
            //    Console.WriteLine(item);
            //}

            //st += " deda";
            //Console.WriteLine(st);

            //StringBuilder sb = new StringBuilder();

            //Console.WriteLine(st.ToString());


            //Console.WriteLine(st.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length);


            //Random random = new Random();


            //int max = Int32.MinValue;
            //int min = Int32.MaxValue;

            //int[,] arr = new int[5, 5];
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        arr[i, j] = random.Next(1, 20);
            //        //if (arr[i,j] > max)
            //        //{
            //        //    max = arr[i,j];
            //        //}
            //        //if (arr[i,j] < min)
            //        //{
            //        //    min = arr[i,j];
            //        //}
            //        Console.Write(arr[i, j].ToString().PadLeft(6, '.'));
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine(min);
            //Console.WriteLine(max);





            //int[] arr = new int[10] { 1,2,3,4,1,2,3,1,2,3};
            //int[] arr1 = new int[10];
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    arr1[i] = random.Next(1, 10);

            //}

            //Console.WriteLine(String.Join(", ", arr1));

            //foreach (var item in arr1)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //int[] arr2 = new int[10];
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    arr2[i] = random.Next(1, 10);

            //}

            //foreach (var item in arr2)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //int size = 0;
            //int[] arr3 = new int[size];

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    if (arr2.Contains(arr1[i]) && !arr3.Contains(arr1[i]))
            //    {
            //        int[] temp = new int[size + 1];
            //        Array.Copy(arr3, temp, arr3.Length);
            //        temp[size] = arr1[i];
            //        arr3 = temp;
            //        size++;
            //    }
            //}

            //foreach (var item in arr3)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();


            //int even = arr.Count(isEven);
            //int odd = arr.Count(a => a % 2 == 1);
            //int distinct = arr.Distinct().Count();

            //Console.WriteLine(even);
            //Console.WriteLine(odd);
            //Console.WriteLine(distinct);

            //int val = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(arr.Count(a=> a > val));

            //int[] arr = new int[10];
            //int[] arr2 = { 2, 3, 2, 56, 7, 8 };
            //int[] arr3;
            //arr3 = new int[]{ 1,23,4,6,7};

            //int[] arr4 = arr;

            //Console.WriteLine(arr.GetLength(0));
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    arr2[i] *= 2;
            //    Console.Write(arr2[i] + " ");
            //}
            //Console.WriteLine();

            //foreach (var item in arr2)
            //{
            //    //item *= 2;
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //Console.WriteLine(arr2.Count(a => a == 4));
            //Console.WriteLine(arr2.Max());
            //Console.WriteLine(arr2.Sum());
            //Array.Sort(arr2);
            //foreach (var item in arr2)
            //{
            //    //item *= 2;
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //int[,] arr5 = new int[3,4];
            //Console.WriteLine(arr5[2,2]);

            //int[][] arr6 = new int[2][];
            //arr6[0] = new int[10];
            //arr6[1] = new int[5];

            //Console.WriteLine(arr6[1][1]);
            //for (int i = 0; i < arr6.GetLength(0); i++)
            //{
            //    foreach (var item in arr6[i])
            //    {

            //    }

            //    for (int j = 0; j < arr6[i].Length; j++)
            //    {

            //    }
            //}


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




            //int num = Convert.ToInt32(Console.ReadLine());


            //int? s = null;



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
