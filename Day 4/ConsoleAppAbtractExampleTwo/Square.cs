using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAbtractExampleTwo
{
    internal class Square:Shape
    {
        readonly double radius;

        public Square(double radius)
        {
            this.radius = radius;
        }

        public override double CalcArea()
        {
            return Math.PI * radius;
        }
    }
}
