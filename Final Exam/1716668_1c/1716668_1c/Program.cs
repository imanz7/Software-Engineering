using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1716668_1c
{
    class Student
    {
        public string Name;
        public double CGPA;
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { Name = "Ali", CGPA = 2.672, Age = 21 });
            students.Add(new Student { Name = "Mahmood", CGPA = 1.492, Age = 22 });
            students.Add(new Student { Name = "Abdullah", CGPA = 2.356, Age = 19 });
            students.Add(new Student { Name = "Azizah", CGPA = 2.241, Age = 25 });
            students.Add(new Student { Name = "Ibrahim", CGPA = 3.556, Age = 24 });
            students.Add(new Student { Name = "Ismail", CGPA = 1.836, Age = 19 });
            students.Add(new Student { Name = "Aida", CGPA = 2.240, Age = 21 });
            students.Add(new Student { Name = "Ahmad", CGPA = 3.592, Age = 20 });
            students.Add(new Student { Name = "Muhammad", CGPA = 2.636, Age = 18 });
            students.Add(new Student { Name = "Shuaib", CGPA = 1.948, Age = 27 });


            List<Student> selectedstudents = students.Where(x => x.Name.StartsWith("A") && x.Age <= 23 && x.Age >= 21).ToList();

            selectedstudents.ForEach(x => Console.WriteLine(x.Name.ToUpper()));
            Console.ReadLine();
        }
    }
}
