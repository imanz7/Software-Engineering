using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_b
{
    class Program
    {
        static void Main(string[] args)
        {
            (string date, string dayofweek) = LookupDate();
            Console.WriteLine(date);
            Console.WriteLine(dayofweek);
            Console.Read();
        }

        public static (string, string) LookupDate ()
        {
            DateTime a = DateTime.Now;
            string date = a.ToString();
            string dayofweek = a.DayOfWeek.ToString();

            return (date, dayofweek);
        }
    }
}
