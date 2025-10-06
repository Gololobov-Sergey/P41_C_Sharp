using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P41_C_Sharp
{
    class Computer
    {
        public string Type { get; set; }
        public string CPU { get; set; }
        public string MotherBoard { get; set; }
        public string RAM { get; set; }
        public string DiscDriver { get; set; }

        public override string ToString()
        {
            return $"{Type} {CPU} {MotherBoard} {RAM} {DiscDriver}";
        }
    }
}
