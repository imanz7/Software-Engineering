using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_c
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector a = new Vector { X = 3.5, Y = 5.4 };
            Vector b = new Vector { X = 0.1, Y = 1.5 };
            Vector a_divideby_b = Vector.DivideBy(a, b);
            Vector d = a / b;

            Console.ReadLine();
        }
    }
}
