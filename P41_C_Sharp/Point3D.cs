using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P41_C_Sharp
{
    public class Point3D<T> /*where T : /*struct, class, IComparable, Student, new()*/
    {
        public T? X { get; set; }
        public T? Y { get; set; }
        public T? Z { get; set; }

        public Point3D()
        {
            X = default;
            Y = default;
            Z = default;
        }

        public Point3D(T x, T y, T z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }

    public class AAA<T>
    {

    }

    class BBB : AAA<int>
    {

    }

    public class CCC<T, V> : AAA<V>
    {
    }


    public class  DDD
    {
        
    }

    public class EEE<T> : DDD
    {

    }


    public class FFF<T>
    {
        public class GGG<U>
        {

        }
    }

}
