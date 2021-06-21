using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1716668_3b
{
    class Program
    {
        static string[] splitline;
        public static int keyVal;
        public static string result;

        static void Main(string[] args)
        {
            Read();
            Console.Read();
        }
        static void Read()
        {
            StreamReader file = new StreamReader(@"D:\names.txt");

            string line;

            Dictionary<string, string> data = new Dictionary<string, string>();
            //keyVal = "000000";
            var temp = 0;

            while ((line = file.ReadLine()) != null)
            {
                temp = keyVal;
                splitline = line.Split('\n');
                data.Add(temp.ToString(), line);
                
                temp += 1;
                keyVal = temp++;
            }
            file.Close();

            Write(data);
        }

        static void Write(Dictionary<string,string> data)
        {
            
            //string items = string.Join(Environment.NewLine, data);
            StringBuilder sb = new StringBuilder();
            foreach (var item in data)
            {
                /*
                //var punctuation = item.Key.Where(Char.IsPunctuation).Distinct().ToArray();
                var words = item.Key.Split().Select(x => x.Trim(' '));
                bool check = words.Contains(NameBox.Text, StringComparer.OrdinalIgnoreCase);
                */
                
                sb.AppendFormat("{0}, {1} \n", item.Key.ToString().PadLeft(5,'0'), item.Value);
                result = sb.ToString().TrimEnd();
            }
            try
            {
                using (StreamWriter file = new StreamWriter(@"D:\withid.txt", true))
                {
                    file.WriteLine(result);
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
