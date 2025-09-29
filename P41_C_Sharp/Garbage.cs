using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P41_C_Sharp
{
    public class Garbage
    {
        public void MakeGarbage()
        {
            for (int i = 0; i < 1000; i++)
            {
                Student st = new Student();
            }
        }
    }
}
