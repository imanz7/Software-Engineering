using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 s1 = new Class1(3,1,5);
            Class1 s2 = new Class1 (1,8,5); // {xvalue = 5, yvalue = 1, zvalue = 9};
            
            Console.WriteLine("Student 1: " + s1.Summation.ToString());
            Console.ReadLine();

            Console.WriteLine("Student 2: " + s2.Summation.ToString());
            Console.ReadLine();

            //Console.WriteLine(s1 + s2);
            Console.WriteLine("Total: " + (s1.sum + s2.sum));

            //var a = total(s1, s2);

            Console.ReadLine();
        }
    }
}
