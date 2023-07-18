using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay4
{
    internal class OurDerived:OurAbClass
    {
        public override void Display(string msg)
        {
            Console.WriteLine("Hi Your Message is " + msg);
        }
    }
}
