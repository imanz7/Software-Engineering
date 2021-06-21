using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 100-999:");

            try
            {
                string inputA = Console.ReadLine();
                int X = int.Parse(inputA);

                char[] letter = inputA.ToCharArray();
                int max = letter.Length - 1;
                if(X>=100 && X<=999)
                {
                    int no = OddEven(X);

                    if (no == 0)
                    {
                        Console.WriteLine("You entered " + inputA + " which consist of " + letter[0] + "x100 + " + letter[1] + "x10 + " + letter[max] + "x1 ");
                    }
                    else
                    {
                       DateTime a = DateTime.Now;
                       a = a.AddDays(X);
                       Console.WriteLine(inputA + " days from today is at " + a);
                    }
                }
            }

            catch (FormatException ex)
            {
                Console.WriteLine("The input must be a number. Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry. Unexpected error: " + ex.Message);
            }
            
            Console.ReadLine();
        }

        static public int OddEven(int X) => X % 2;
    }
}
