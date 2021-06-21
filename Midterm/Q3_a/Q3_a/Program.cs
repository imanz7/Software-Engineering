using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_a
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<long, bool> func = Method1;
            bool result = Method1(56);

            Action<int, string> action = Method2;
            Method2(5, "a");

            Action act2 = Method3;
            Method3();

            Func<int, int, int, ulong> fn2 = Method4;
            ulong number = Method4(5, 7, 9);

            Console.ReadLine();
        }

        static bool Method1(long a)
        {
            return a > 50;
        }
        static void Method2(int a, string b)
        {
            Console.WriteLine(a.ToString() + "," + b);
        }
        static void Method3()
        {
            Console.WriteLine("Hi");
        }
        static ulong Method4(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return (ulong)Math.Pow(a, b);
            }
            else
            {
                return (ulong)Math.Pow(b, c);
            }
        }
    }
}
