using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft_Exercise
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("1st input:");
            string inputA = Console.ReadLine();
            //int X = int.Parse(inputA);

            Console.Write("2nd input:");
            string inputB = Console.ReadLine();
            //int Y = int.Parse(inputB);

            //int sum = (X == Y) ? (3*(X + Y)) : (X + Y);
            //Console.WriteLine("Summation value: " + sum);
            
            char[] letter = inputA.ToCharArray();
            //int max = letter.Length;
            for(int i =0, max = letter.Length - 1; max > 0; max--, i++)
            {
                char temp = letter[max];
                letter[max] = letter[i];
                letter[i] = temp;
            }
            string rev = new string(letter);
            Console.WriteLine("Reversed string: " + rev.ToUpper());
            Console.WriteLine();

            Vector V1 = new Vector {setX = 3.5, Y = 7.0, Z = 4.0 };
            Vector V2 = new Vector();
            V2.setX = 1.2;
            V2.Y = 2.0;
            V2.Z = 9.2;

            Console.WriteLine("The magnitude of the vector 1 is " + V1.magnitude());
            Console.WriteLine("Magnitude of V2 is " + V2.magnitude());
            Console.WriteLine();

            Console.WriteLine(inputB + " " + inputB + " " + inputB + " " + inputB);
            Console.Write(inputB);

            for (int i = 0; i < 4; i++)
            {
                Console.Write(inputB);
                
            }
            Console.WriteLine();

            /*
            int X = int.Parse(inputA);
            int Y = int.Parse(inputB);

            if (X < 0 && Y<0 || X>0 && Y > 0)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
            */
            Console.ReadLine();
        }
    }
}
