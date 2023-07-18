using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercise_1
{
    public class Rectangle
    {

        double length;
        double breadth;
        double area;
        public Rectangle(double length, double breadth,double area)
        {
            this.length = length;
            this.breadth = breadth;
            this.area = area;
        }

            public double Area() {
            return length * breadth;
                }

        public double Length() {
            return area / breadth;
        }

        public double Breadth()
        {
            return area / length;
        }

    }
}
