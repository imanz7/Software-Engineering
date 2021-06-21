using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1716668_3a
{
    class Program
    {
        static string[] splitline;

        static void Main(string[] args)
        {
            Read();
            Console.Read();
        }
        static void Read()
        {
            StreamReader file = new StreamReader(@"D:\names.txt");

            string line;

            List<string> data = new List<string>();
            //Dictionary<string, string> data = new Dictionary<string, string>();

            while ((line = file.ReadLine()) != null)
            {
                splitline = line.Split('\n');
                data.Add(splitline[0]);
                
                
            }
            file.Close();

            Write(data);
        }

        static void Write(List<string> data)
        {
            
            data.Sort();
            string items = string.Join(Environment.NewLine, data);

            try
            {
                using (StreamWriter file = new StreamWriter(@"D:\sorted.txt", true))
                {
                    file.WriteLine(items);
                    file.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("File is not exist.\n Error: " + ex.Message);
            }
        }
    }
}
