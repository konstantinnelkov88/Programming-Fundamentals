using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrades
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }

        public double AverageGrades
        {
            get { return Grades.Average(); }
        }

        public Student(string name, List<double> grades)
        {
            this.Name = name;
            this.Grades = grades;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                
                var input = Console.ReadLine().Split(' ').ToList();
                string name = input[0];
                input.Remove(input[0]);
                List<double> grades = input.Select(double.Parse).ToList();
                
                Student student = new Student(name,grades);
                students.Add(student);
            }
            
            foreach (var student in students.OrderByDescending(x=>x.AverageGrades).Where(x=>x.AverageGrades>=5.00).OrderBy(x=>x.Name))
            {
                Console.WriteLine("{0} -> {1:f2}", student.Name, student.AverageGrades);
            }
        }
    }
}