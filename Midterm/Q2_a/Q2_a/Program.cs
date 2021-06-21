using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_a
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = { "air", "water", "food", "clothes" };
            int[] b = { 8, 7, 4, 2, 11 };
            DoSort(a, "ascending");
            DoSort(b, "descending");

            foreach (string theitem in a)
            {
                Console.WriteLine(theitem);
            }
            foreach (int theitem in b)
            {
                Console.WriteLine(theitem);
            }

            Console.ReadLine();
        }

        public static void DoSort (string[] x, string y)
        {
            if (y == "ascending")
            {
                Array.Reverse(x);
            }
            else
            {

            }
        }

        public static void DoSort(int[] x, string y)
        {
            if (y == "ascending")
            {
                Array.Reverse(x);
            }
            else
            {

            }
        }
    }
}
