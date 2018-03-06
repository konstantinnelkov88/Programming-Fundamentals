using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace MentorGroup
{
    class Student
    {
        public string Name { get; set; }

        public List<string> Comments { get; set; }

        public List<DateTime> Dates { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> Students = new List<Student>();

            while (true)
            {
                var info = Console.ReadLine();

                if (info == "end of dates") break;

                var entry = info.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var name = entry[0];

                if (Students.Any(c => c.Name == name))
                {
                    Student existingStudent = Students.First(c => c.Name == name);

                    if (entry.Length > 1)
                    {
                        for (int i = 1; i <= entry.Length - 1; i++)
                        {
                            DateTime date = DateTime.ParseExact(entry[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                            existingStudent.Dates.Add(date);
                        }
                    }
                }
                else
                {
                    Student student = new Student();

                    student.Name = name;

                    student.Dates = new List<DateTime>();

                    student.Comments = new List<string>();

                    if (entry.Length > 1)
                    {
                        for (int i = 1; i <= entry.Length - 1; i++)
                        {
                            DateTime date = DateTime.ParseExact(entry[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                            student.Dates.Add(date);
                        }
                    }
                    Students.Add(student);
                }
            }

            while (true)
            {
                var info = Console.ReadLine();

                if (info == "end of comments") break;

                var entry = info.Split('-').ToArray();

                var name = entry[0];

                var comment = entry[1];

                if (Students.Any(c => c.Name == name))
                {
                    Student existingStudent = Students.First(c => c.Name == name);

                    existingStudent.Comments.Add(comment);
                }
                else
                {
                    continue;
                }
            }

            foreach (var student in Students.OrderBy(c=>c.Name))
            {
                Console.WriteLine(student.Name);

                Console.WriteLine("Comments:");

                if (student.Comments.Count != 0)
                {
                    foreach (var comment in student.Comments)
                    {
                        Console.WriteLine("- {0}", comment);
                    }
                }

                Console.WriteLine("Dates attended:");

                if (student.Dates.Count != 0)
                {
                    
                    foreach (var date in student.Dates.OrderBy(x => x.Date))
                    {
                        Console.WriteLine("-- {0:dd/MM/yyyy}", date);
                    }
                }
            }
        }
    }
}