using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public class Calculator
    {
        public long Sum(int a, int b)
        {
            return (long)a + (long)b;
        }

        public long Subtract(int a, int b)
        {
            return (long)a - (long)b;
        }

        public long Multiply(int a, int b)
        {
            return (long)a * (long)b;
        }

        public double Div(int a, int b)
        {
            return (double)a / (double)b;
        }
    }
}
