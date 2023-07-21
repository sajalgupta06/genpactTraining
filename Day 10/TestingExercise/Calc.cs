using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingExercise
{
   
    public class Calc
    {

        public double Add(int i, int j)
        {
            return i + j;
        }
        public double Subtract(int i, int j)
        {
            return i - j;
        }

        public double Multiply(int i, int j)
        {
            return i * j;
        }
        public double Divide(int i, int j)
        {
            if(j==0)
            {
                throw new DivideByZeroException("Division by zero not possible");
            }
            return i / j;
        }

        public bool IsPrime(int n)
        {
            if (n == 1) return false;
            if(n==2) return true;
            for(int i = 2;i<=Math.Sqrt(n);i++)
            {
                if(n%i==0) return false;
            }
            return true;
        }
    }
}
