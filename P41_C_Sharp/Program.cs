


using System.Collections;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using static P41_C_Sharp.Program;


namespace P41_C_Sharp
{
    internal class Program
    {



        static void Func(ref int[] arr, ref int i, out int b)
        {
            foreach (var x in arr)
            {
                Console.WriteLine(x + " ");
            }
            Console.WriteLine();
            Console.WriteLine(i);

            arr = new int[] { 6, 76, 8 };
            i++;

            foreach (var x in arr)
            {
                Console.WriteLine(x + " ");
            }
            Console.WriteLine();
            Console.WriteLine(i);

            b = 999;
        }

        static int Sum(params object[] a)
        {
            int res = 0;
            //foreach (var x in a)
            //    res += x;
            return res;
        }

        static void WorkInfo(IWork m)
        {
            m.Work();
        }

        static void Output(IOutput obj)
        {
            obj.Show();
            obj.Show("Info");
        }


        static void PrintGroup(Hashtable group)
        {
            // LN FN - Marks

            foreach (Student key in group.Keys)
            {
                Console.Write($"{key.LastName} {key.FirstName} - ");
                foreach (int item in (ArrayList)group[key])
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }
        }


        static void AddMarkStudent(Hashtable group, string lastName, string firstName, int mark)
        {
            foreach (Student key in group.Keys)
            {
                if (key.FirstName == firstName && key.LastName == lastName)
                {
                    ((ArrayList)group[key]).Add(mark);
                }
            }
        }


        static T MaxElem<T>(T[] arr) where T : IComparable<T>
        {
            T max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i].CompareTo(max) > 0)
                    max = arr[i];
            }
            return max;
        }


        static T Maximym<T>(params T[] arr) where T : IComparable<T>
        {
            return arr.Max()!;
        }


        static T Sum<T>(T[] arr) where T : ISum<T>, new()
        {
            T sum = new T();
            foreach (var item in arr)
            {
                sum.Sum(item);
            }
            return sum;
        }


        static T F<T>(int a)
        {
            return default;
        }

        static void VoidFunc()
        {
            Console.WriteLine("VoidFunc");
        }

        static void VoidFunc2()
        {
            Console.WriteLine("VoidFunc2");
        }

        static void PrintInt(int a)
        {
            Console.Write(a + " ");
        }


        static void PrintStudent(Student s)
        {
            Console.WriteLine($"{s.LastName,-10} {s.FirstName,-8}");
        }

        static bool big1990(Student s)
        {
            return s.BirthDay.Year > 2000;
        }

        static decimal FromBD(Student s)
        {
            return (DateTime.Now - s.BirthDay).Days;
        }

        static int FromBD(Student s1, Student s2)
        {
            return s1.BirthDay.CompareTo(s2.BirthDay);
        }


        public delegate void VoidDelegate();

        public delegate int CalcDelegate(int a, int b);

        public delegate T1 T_Delegate<T1, T2, T3>(T2 a, T3 b);


        static double Div(int a, int b)
        {
            try
            {
                if (b == 0)
                    throw new DivideByZeroException(nameof(b));
                return (double)a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!");
                throw new Exception("Error", ex);
            }

        }

        static void Main(string[] args)
        {
            Console.Title = "P41 C#";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Clear();


            // 04.10.2025
            Console.WriteLine("Class Author:");
            foreach (var item in typeof(Student).GetCustomAttributes(false))
            {
                if(item is ProgrammerAttribute)
                    Console.WriteLine(item);
            }

            Console.WriteLine("Method Autors:");
            foreach (var method in typeof(Student).GetProperties())
            {
                Console.Write($"{method.Name} - ");
                foreach (var item in method.GetCustomAttributes(false))
                {
                    if (item is ProgrammerAttribute)
                        Console.WriteLine($"{item}");
                    else
                        Console.WriteLine("No programmer attribute");   
                }

            }


            //string pattern = @"^-?\d+$";
            // +38(050)125-45-45
            //string pattern = @"^\+38\(0\d{2}\)\d{3}-\d{2}-\d{2}$";
            //string pattern = @"^\-?\d+(\.\d+)?$";
            //string pattern = @"^[A-Z]\w*(\-[A-Z]\w*){0,2} [A-Z]\w*$";
            //Regex regex = new Regex(pattern);

            //while(true)
            //{
            //    string text = Console.ReadLine();
            //    Console.WriteLine(regex.IsMatch(text));
            //}





            //DirectoryInfo dir = new DirectoryInfo(".");
            //Console.WriteLine(dir.FullName);
            //var files = dir.GetFiles();
            //foreach (var item in files)
            //{
            //    if((item.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
            //    {
            //        Console.WriteLine($"{item.Name,20} {item.Length,20} {item.Attributes,20}");
            //    }

            //}

            //DirectoryInfo dir = new DirectoryInfo("C:\\Test");
            //if(!dir.Exists)
            //    dir.Create();
            //dir.CreateSubdirectory("Test1");


            //FileInfo file = new FileInfo("C:\\Test\\test.txt");
            //if(file.Exists)
            //{
            //    Console.WriteLine(File.ReadAllText(file.FullName));
            //}

            //StreamWriter sw = File.CreateText("C:\\Test\\test2.txt");
            //sw.Write("Hello dfghdfh");
            //sw.Close();

            //var dir = Directory.GetLogicalDrives();
            //foreach (var item in dir)
            //{
            //    Console.WriteLine(item);
            //}


            //FileInfo file = new FileInfo("C:\\Test\\test.txt");
            //file.Delete();


            //DirectoryInfo dir = new DirectoryInfo("C:\\");
            //while(true)
            //{
            //    var dirs = dir.GetDirectories().Select(s => s.Name).ToList();
            //    var files = dir.GetFiles().Select(f => f.Name).ToList();
            //    dirs.AddRange(files);

            //    int c = ConsoleMenu.SelectVertical(HPosition.Left, VPosition.Top, HorizontalAlignment.Right, dirs);

            //    dir = new DirectoryInfo(dirs[c]);
            //}


            // 29.09.2025


            //using(FileStream fs = new FileStream("file.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            //{
            //    string text = Console.ReadLine()!;
            //    byte[] buffer = Encoding.UTF8.GetBytes(text);
            //    fs.Write(buffer, 0, buffer.Length);

            //}


            //using(FileStream fs = new FileStream("file.bin", FileMode.Open, FileAccess.Read, FileShare.None))
            //{
            //    byte[] buffer = new byte[fs.Length];
            //    fs.Read(buffer, 0, buffer.Length);
            //    string text = Encoding.UTF8.GetString(buffer);
            //    Console.WriteLine(text);
            //}



            //using(FileStream fs = new FileStream("file1.txt", FileMode.Create))
            //{
            //    using(StreamWriter writer = new StreamWriter(fs, Encoding.UTF8))
            //    {
            //        writer.WriteLine("Hello");
            //        writer.WriteLine("World");
            //    }
            //}


            //using(FileStream fs = new FileStream("file1.txt", FileMode.Open))
            //{
            //    using(StreamReader reader = new StreamReader(fs, Encoding.UTF8))
            //    {
            //        while (!reader.EndOfStream)
            //        {
            //            string line = reader.ReadLine()!;
            //            Console.WriteLine(line);
            //        }
            //    }
            //}


            //using(FileStream fs = new FileStream("file2.bin", FileMode.Create))
            //{
            //    using(BinaryWriter writer = new BinaryWriter(fs, Encoding.UTF8))
            //    {
            //        writer.Write(123);
            //        writer.Write(45.67);
            //        writer.Write(true);
            //        writer.Write("Hello");
            //    }
            //}

            //using(FileStream fs = new FileStream("file2.bin", FileMode.Open))
            //{
            //    using(BinaryReader reader = new BinaryReader(fs, Encoding.UTF8))
            //    {
            //        int a = reader.ReadInt32();
            //        double d = reader.ReadDouble();
            //        bool b = reader.ReadBoolean();
            //        string s = reader.ReadString();
            //        Console.WriteLine($"{a} {d} {b} {s}");
            //    }
            //}


            //Console.WriteLine(GC.MaxGeneration);
            //Garbage garbage = new Garbage();
            //Console.WriteLine(GC.GetGeneration(garbage));
            //Console.WriteLine(GC.GetTotalMemory(false));
            //garbage.MakeGarbage();
            //Console.WriteLine(GC.GetGeneration(garbage));
            //Console.WriteLine(GC.GetTotalMemory(false));
            //GC.Collect();
            //Console.WriteLine(GC.GetGeneration(garbage));
            //Console.WriteLine(GC.GetTotalMemory(false));

            //GC.Collect();
            //Console.WriteLine(GC.GetGeneration(garbage));
            //Console.WriteLine(GC.GetTotalMemory(false));


            //unchecked
            //{
            //    byte b = 100;
            //    b = (byte)(b + 200);
            //    Console.WriteLine(b);
            //}

            //try
            //{

            //    int a = Convert.ToInt32(Console.ReadLine());
            //    int b = Convert.ToInt32(Console.ReadLine());
            //    int c = (int)Div(a, b);
            //    Console.WriteLine(c);
            //}
            //catch (Exception ex) when (ex is DivideByZeroException || ex is FormatException)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.StackTrace);
            //    Console.WriteLine(ex.TargetSite);
            //    Console.WriteLine(ex.InnerException!.Message);
            //    Console.WriteLine(ex.Source);

            //}
            //finally
            //{

            //}



            // 27.09.2025


            //CalcDelegate calc = null;

            //calc += delegate (int a, int b)
            //{
            //    return a + b;
            //};

            //calc += (a, b) => a - b;

            //// [](){}
            //// () => { }

            //Predicate<DateTime> isWeekend = d => d.DayOfWeek == DayOfWeek.Saturday || d.DayOfWeek == DayOfWeek.Sunday;

            //Console.WriteLine(isWeekend(DateTime.Now));


            //List<Student> students = new List<Student>
            //{
            //    new Student { LastName="Sidorov", FirstName="Ivan",   BirthDay=new DateTime(2000,10,5), StudentCard=new StudentCard { Series="AC", Number=123456 } },
            //    new Student { LastName="Ivanova", FirstName="Maria",  BirthDay=new DateTime(2000,10,3), StudentCard=new StudentCard { Series="AB", Number=123455 } },
            //    new Student { LastName="Ivanov",  FirstName="Sidr",   BirthDay=new DateTime(2002,3,3),  StudentCard=new StudentCard { Series="AA", Number=123456 } },
            //    new Student { LastName="Smirnov", FirstName="Sergey", BirthDay=new DateTime(1999,4,4),  StudentCard=new StudentCard { Series="AB", Number=123466 } }
            //};

            //Teacher teacher = new Teacher { Name = "Gololobov Serhiy" };

            //foreach (var item in students)
            //{
            //    teacher.ExamEvent += item.Exam;
            //}

            //teacher.SetExam("22.09.2025");

            //Console.WriteLine();
            //teacher.ExamEvent -= students[1].Exam;

            //teacher.SetExam("27.09.2025");





            // 22.09.2025


            //List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //list.ForEach(PrintInt);


            //List<Student> students = new List<Student>
            //{
            //    new Student { LastName="Sidorov", FirstName="Ivan",   BirthDay=new DateTime(2000,10,5), StudentCard=new StudentCard { Series="AC", Number=123456 } },
            //    new Student { LastName="Ivanova", FirstName="Maria",  BirthDay=new DateTime(2000,10,3), StudentCard=new StudentCard { Series="AB", Number=123455 } },
            //    new Student { LastName="Ivanov",  FirstName="Sidr",   BirthDay=new DateTime(2002,3,3),  StudentCard=new StudentCard { Series="AA", Number=123456 } },
            //    new Student { LastName="Smirnov", FirstName="Sergey", BirthDay=new DateTime(1999,4,4),  StudentCard=new StudentCard { Series="AB", Number=123466 } }
            //};

            //var wd = students.FindAll(s => isWeekend(s.BirthDay));
            //foreach (var item in wd)
            //{
            //    Console.WriteLine(item);
            //}


            //students.ForEach(s=> Console.WriteLine(s));

            //Console.WriteLine(students.All(big1990));
            //Console.WriteLine(students.Count(big1990));
            //students.RemoveAll(big1990);
            //Console.WriteLine(students.Find(s => (DateTime.Now - s.BirthDay).Days == students.Min(FromBD)));

            //students.Sort((s1, s2) => s1.BirthDay.CompareTo(s2.BirthDay));
            //students.ForEach(s => Console.WriteLine(s));

            //string st = "mama";
            //Console.WriteLine(st.Mult(5));

            //Console.Write(st.PadCenter(20));
            //Console.WriteLine(st);
            //int a = 10;
            //Console.WriteLine(a.isEven());

            //string m = "qwert";
            //if (m.Contains('q'))
            //{

            //}




            //VoidDelegate del = new VoidDelegate(VoidFunc);
            ////del();
            //del += VoidFunc2;
            ////del();

            ////((VoidDelegate)(del.GetInvocationList()[1]))();

            //foreach (VoidDelegate item in del.GetInvocationList())
            //{
            //    item();
            //}


            //Calculator calculator = new Calculator();
            //string expr = Console.ReadLine()!;
            //string[] parts = expr.Split(' ');
            //// 10 + 20
            //int a = Int32.Parse(parts[0]);
            //int b = Int32.Parse(parts[2]);
            //char oper = parts[1][0];

            //T_Delegate<int, int, int> calc = null;
            //calc = new T_Delegate<int, int, int>(calculator.Sum);
            //calc += calculator.Diff;
            //calc += new T_Delegate<int, int , int> (Calculator.Mult);
            //calc += calculator.Div;

            //foreach (CalcDelegate item in calc.GetInvocationList())
            //{
            //    Console.WriteLine(item(a, b));
            //}

            //Console.WriteLine();
            //calc -= calculator.Diff;
            //foreach (CalcDelegate item in calc.GetInvocationList())
            //{
            //    Console.WriteLine(item(a, b));
            //}


            //switch (oper)
            //{
            //    case '+':
            //        calc = new CalcDelegate(calculator.Sum);
            //        break;
            //    case '-':
            //        calc = calculator.Diff;
            //        break;
            //    case '*':
            //        calc = new CalcDelegate(Calculator.Mult);
            //        break;
            //    case '/':
            //        calc = calculator.Div;
            //        break;
            //    default:
            //        break;
            //}

            //int res = calc(a, b);
            //Console.WriteLine(res);

            // 20.09.2025

            //Point p1 = new Point(10, 20, 1);
            //Point p2 = new Point(5, 15, 2);
            //Point p3 = new Point(30, 25, 3);

            ////Point p = Maximym(p1, p2, p3);
            ////p.Print();


            //Point[] points = new Point[] { p1, p2, p3 };
            //Point sumPoints = Sum(points);
            //sumPoints.Print();


            //int[] arr = new int[] { 1, 2, 3, 4, 5 };
            //int max = Sum(arr);
            //Console.WriteLine(max);

            //Point p = F<Point>(10);

            //Point3D<int> p = new Point3D<int> { X = 10, Y = 20, Z = 30 };

            //Point3D<Student> point3D = new();

            //Console.WriteLine(typeof(Point3D<int>));

            //FFF<int>.GGG<string> ggg = new FFF<int>.GGG<string>();


            // 15.09.2025


            //ArrayList list = new ArrayList();
            //list.Add(10);
            //list.Add("mama");
            //list.Add(new Point2D { X = 10, Y = 20 });

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(list.Capacity);

            //list.Add(10);
            //list.Add("mama");

            //Console.WriteLine(list.Capacity);


            //Student st1 = new Student
            //{
            //    LastName = "Sidorov",
            //    FirstName = "Ivan",
            //    BirthDay = new DateTime(2000, 10, 5),
            //    StudentCard = new StudentCard
            //    {
            //        Series = "AC",
            //        Number = 123456
            //    }
            //};

            //Student st2 = new Student
            //{
            //    LastName = "Sidorov",
            //    FirstName = "Ivan",
            //    BirthDay = new DateTime(2000, 10, 5),
            //    StudentCard = new StudentCard
            //    {
            //        Series = "AC",
            //        Number = 123456
            //    }
            //};

            //Hashtable table = new Hashtable();
            //table.Add(st1, st1);
            //table.Add(st2, st2);



            //foreach (var item in table.Keys)
            //{
            //    Console.WriteLine(item.GetHashCode());
            //}


            //SortedList sortedList = new SortedList();
            //sortedList.Add(3, "three");
            //sortedList.Add(1, "one");

            //sortedList.Add(2, "two");

            //foreach (var item in sortedList.Keys)
            //{
            //    Console.WriteLine(sortedList[item]);
            //}



            //Hashtable group = new Hashtable
            //{
            //    {
            //        new Student
            //        {
            //            LastName = "Sidorov",
            //            FirstName = "Ivan",
            //            BirthDay = new DateTime(2000, 10, 5),
            //            StudentCard = new StudentCard
            //            {
            //                Series = "AC",
            //                Number = 123456
            //            }
            //        },
            //        new ArrayList{ 8,9,8,6}
            //    },

            //    { 
            //        new Student
            //        {
            //            LastName = "Ivanova",
            //            FirstName = "Maria",
            //            BirthDay = new DateTime(2000, 10, 3),
            //            StudentCard = new StudentCard
            //            {
            //                Series = "AB",
            //                Number = 123455
            //            }
            //        },
            //        new ArrayList{ 7,9,8,10}
            //    },

            //    {
            //        new Student
            //        {
            //            LastName = "Ivanov",
            //            FirstName = "Sidr",
            //            BirthDay = new DateTime(2002, 3, 3),
            //            StudentCard = new StudentCard
            //            {
            //                Series = "AA",
            //                Number = 123456
            //            }
            //        },
            //        new ArrayList{ 6,9,8,9}
            //    }
            //};

            //PrintGroup(group);
            //AddMarkStudent(group, "Ivanov", "Sidr", 99);
            //Console.WriteLine();
            //PrintGroup(group);


            //using (new OperationTimer("ArrayList"))
            //{
            //    ArrayList arrayList = new ArrayList();
            //    for (int i = 0; i < 1000000; i++)
            //    {
            //        arrayList.Add(i);
            //        int a = (int)arrayList[i];
            //    }
            //    arrayList = null;
            //}

            //using (new OperationTimer("List<int>"))
            //{
            //    List<int> list = new List<int>();
            //    for (int i = 0; i < 1000000; i++)
            //    {
            //        list.Add(i);
            //        int a = list[i];
            //    }
            //    list = null;
            //}


            //List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //}

            //List<int> list1 = [];
            //List<int> list2 = new();

            //Dictionary<string, int> dict = new Dictionary<string, int>
            //{
            //    { "one", 1 },
            //    { "two", 2 },
            //    { "three", 3 }
            //};

            //dict["four"] = 4;
            //Console.WriteLine(dict["four"]);

            //foreach (var item in dict.Keys)
            //{
            //    Console.WriteLine($"{item} - {dict[item]}");
            //}

            //Dictionary<Student, List<int>> dictStudents = new();

            // 13.09.2025

            //Student st1 = new Student
            //{
            //    LastName = "Sidorov",
            //    FirstName = "Ivan",
            //    BirthDay = new DateTime(2000, 10, 5),
            //    StudentCard = new StudentCard
            //    {
            //        Series = "AC",
            //        Number = 123456
            //    }
            //};

            //Student st2 = (Student)st1.Clone();

            //st2.StudentCard.Number = 999999;

            //Console.WriteLine(st1);


            //StudentCard sc = new StudentCard { Series = "AA", Number = 123456 };
            //Console.WriteLine(sc);
            //StudentCard sc2 = (StudentCard)sc.Clone();

            // 08.09.2025


            //Group group = new Group();
            //Console.WriteLine("Group");
            //Console.WriteLine("----------------------------------------");
            //foreach (Student s in group)
            //{
            //    Console.WriteLine(s);
            //}

            ////group.Sort(new DateComparer());
            ////group.Sort(Student.FromBirthDay);

            //group.Sort(new StudentCardComparer());
            //group.Sort(Student.FromStudentCard);

            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------");
            //foreach (Student s in group)
            //{
            //    Console.WriteLine(s);
            //}


            //Inter2 inter = new Inter2();
            //(inter as IAA).Show();

            //IAA interA = new Inter2();
            //interA.Show();

            //IBB interB = new Inter2();
            //interB.Show();

            //ICC interC = new Inter2();
            //interC.Show();



            //Manager manager = new Manager("Stepan", 40, 2000, 500);
            ////manager.Work();
            //WorkInfo(manager);

            //Employee e = new Employee("Petro", 35, 1000);
            //WorkInfo(e);


            //IOutput output = new Currency("USD", 42.550m, 1000);
            //Output(output);

            // 06.09.2025

            //Point3D p3d = new Point3D { X = 10, Y = 20, Z = 30 };
            //p3d.Print();

            //Point2D p2d = new Point2D { X = 10, Y = 15 };
            //Console.WriteLine(p2d);

            ////Human h = new Human("Ivan", 30);
            ////Console.WriteLine(h);

            //Employee e = new Employee("Petro", 35, 1000);
            //Console.WriteLine(e);

            //Array array = new int[10];


            //Human m = new Manager("Stepan", 40, 2000, 500);
            //Console.WriteLine(m);

            //Manager mm = (Manager)m;
            //mm.Print();

            //Manager? mmm = m as Manager;
            //if (mmm != null)
            //{
            //    mmm.Print();
            //}


            //if(m is Manager)
            //{
            //    ((Manager)m).Print();
            //    (m as Manager).Print();
            //}

            // 30.06.2025

            // Створіть клас Player із властивостями Name, Score і Level. 
            // Властивість Score має автоматично збільшувати рівень гравця(Level), 
            // коли кількість очок досягає певного порога.
            // Використовуйте автоматичні властивості для полів Name і Score. 
            // Реалізуйте логіку в set-аксесорі властивості Score, щоб перевіряти 
            // необхідність підвищення рівня гравця.


            // Створіть клас Currency, який виконує конвертацію між різними 
            // валютами(наприклад, USD, EUR, GBP). Реалізуйте оператори явного і 
            // неявного перетворення для конвертації між валютами.
            // Використовуйте властивості для зберігання назви валюти 
            // та її курсу обміну. Реалізуйте як явні(explicit), 
            // так і неявні(implicit) оператори перетворення.

            //Currency curr = new Currency("USD", 42.550m, 1000);
            //decimal sum = curr;
            //Currency curr2 = (Currency)curr;



            //Point2D p = new Point2D { X = 5, Y = 5 };
            //if (p && p)
            //{
            //    Console.WriteLine("Point is empty");
            //}
            //else
            //{
            //    Console.WriteLine("Point is not empty");
            //}

            //float f = p;

            //if(p == 3.3)
            //{

            //}

            //Apple a = (Apple)p;

            //p[0] = 10;
            //Console.WriteLine(p["1"]);

            // 28.06.2025




            //ToDoList toDoList = new ToDoList();
            //toDoList.Add(new Task { Name = "Exam1", Description = "Exam on C#", Status = TaskStatus.InProgress });
            //toDoList.Add(new Task { Name = "Exam2", Description = "Exam on C++", Status = TaskStatus.NotStarted });
            //toDoList.Add(new Task { Name = "Exam3", Description = "Exam on SQL", Status = TaskStatus.NotStarted });
            //toDoList.Add(new Task { Name = "Exam4", Description = "Exam on EF Core", Status = TaskStatus.Deferred });

            //toDoList.PrintTasks(TaskStatus.NotStarted);

            //toDoList.ChangeStatus(TaskStatus.Completed, 0);
            //toDoList.PrintTasks(TaskStatus.Completed);

            // - -- ++
            // + - * / % 
            // < > <= >= == != true/false 
            // && || !
            // () []


            // +=, = , . , ?: , new , sizeof , is , as , 


            //Point2D p = new Point2D { X = 5, Y = 5 };
            //Point2D p2 = -p;
            //p2.Print();
            //(p2++).Print();
            //(++p2).Print();

            //Point2D p3 = p + p2;
            //p3.Print();

            //p += p2;
            //p.Print();

            //p += 10;
            //p.Print();

            //p = 10 + p;


            //Apple a1 = new Apple { Radius = 10, Color = ConsoleColor.Green };
            //Apple a2 = new Apple { Radius = 15, Color = ConsoleColor.Red };
            //Kompot k = a1 + a2;
            //k.Print();

            //Apple a3 = new Apple { Radius = 5, Color = ConsoleColor.Yellow };
            //k += a3;

            //k += "water 1l";
            //k += "sugar 200g";

            //k.Print();

            //Console.WriteLine(k["fruits", 0]);
            //Console.WriteLine(k["ingradients", 1]);



            //Student student = new Student
            //{
            //    LastName = "Ivanov",
            //    FirstName = "Ivan",
            //    BirthDate = new DateTime(2000, 1, 1),
            //    Id = 1
            //};

            //Student student2 = student;

            //F.Func.isEven(2);


            // 23.06.2025


            //BirthDay birthDay = new BirthDay(1976, 5, 20);
            //Console.WriteLine(birthDay.GetDayOfWeek());
            //Console.WriteLine(birthDay.GetDayOfWeek(2025));

            //Point point = new Point(12,34, 200);

            //Point point1 = new Point();
            //point1.Print();


            //Console.WriteLine(Point.GetCount());

            //Console.WriteLine(Sum(1,"2",true, new Point()));


            //int[] arr = { 1, 2, 3 };
            //int i = 100;

            //Func(ref arr, ref i, out int b);

            //foreach (var x in arr)
            //{
            //    Console.WriteLine(x + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine(i);
            //Console.WriteLine(b);


            //Int32.TryParse(Console.ReadLine(), out int res);
            //Console.WriteLine(res);


            //foreach (var item in Enum.GetValues(typeof(DayOfWeek)))
            //{
            //    Console.WriteLine(item);
            //}


            // 21.06.2025

            //string? str = Console.ReadLine();

            //var words = str.Split();
            //for (int i = 0; i < words.Length; i++)
            //{
            //    words[i] = new string(words[i].Reverse().ToArray());
            //}

            //Console.WriteLine(String.Join(' ', words));




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
