using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P41_C_Sharp
{
    internal interface IWork
    {
        void Work();
        bool IsWorking {  get; }
    }
}
