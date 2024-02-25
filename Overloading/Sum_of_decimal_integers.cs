using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    public class Sum_of_decimal_integers
    {
        public int Sum (int j, int k) // Here is the sum of 2 integers
        {
            return j + k;
        }

        public int Sum (int x, int y, int z) // Here is the sum of 3 integers
        {
            return x + y + z;
        }

        public double Sum (double m, double n) // Here is the sum of 2 decimal numbers
        { 
            return m + n; 
        }
        public double Sum (double a, double b, double c, double d) // Here is the sum of 4 decimal numbers
        { 
            return a + b + c + d; 
        }
    }
}
