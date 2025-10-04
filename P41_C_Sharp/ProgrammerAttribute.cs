using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P41_C_Sharp
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property)]
    public class ProgrammerAttribute : Attribute
    {
        string programmer = "Gololobov S.A.";
        DateTime date = DateTime.Now;

        public ProgrammerAttribute() { }

        public ProgrammerAttribute(string prog, string date)
        {
            programmer = prog;
            this.date = DateTime.Parse(date);
            
        }

        public override string ToString()
        {
            return $"Programmer: {programmer}, Date: {date.ToShortDateString()}";
        }
    }
}
