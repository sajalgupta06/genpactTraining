using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay4
{
    internal abstract class OurAbClass
    {

        int ourfield;

        public OurAbClass()
        {
            Console.WriteLine("Abstract class constructor");
            ourfield = 1;
        }

        public int ourProp { get { return ourfield; } set { ourfield = value; } }

        public abstract void Display(string msg);
        


        
    }
}
