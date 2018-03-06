using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace StudentGroups
{
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
    }

    class Town
    {
        public string Name { get; set; }
        public int SeatsCount { get; set; }
        public List<Student> Students { get; set; }
    }

    class Group
    {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var towns = new List<Town>();

            towns = readTownsAndStudents();

            var Groups = new List<Group>();

            Groups = DistributeStudentsIntoGroups(towns);

            Console.WriteLine("Created {0} groups in {1} towns:", Groups.Count, towns.Count);

            foreach (Group theGroup in Groups)
            {
                var students = theGroup.Students;

                Console.Write("{0} => ", theGroup.Town.Name);

                foreach (var student in students)
                {
                    if (student == students.Last())
                    {
                        Console.Write("{0}", string.Join(" ", student.Email));
                    }
                    else
                    {
                        Console.Write("{0}, ", string.Join(" ", student.Email));
                    }
                }
                Console.WriteLine();
            }
        }

        public static List<Group> DistributeStudentsIntoGroups(List<Town> towns)
        {
            var groups = new List<Group>();

            foreach (var town in towns.OrderBy(x => x.Name))
            {
                IEnumerable<Student> students = town
                    .Students.OrderBy(s => s.RegistrationDate)
                    .ThenBy(x => x.Name)
                    .ThenBy(v => v.Email);

                while (students.Any())
                {
                    var group = new Group();
                    group.Town = town;
                    group.Students = students.Take(group.Town.SeatsCount).ToList();
                    students = students.Skip(group.Town.SeatsCount);
                    groups.Add(group);
                }
            }
            return groups;
        }

        public static List<Town> readTownsAndStudents()
        {
            var towns = new List<Town>();

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "End") break;

                if (inputLine.Contains("=>"))
                {
                    var town = new Town();
                    var parsed = inputLine.Split(new char[] { '=', '>' }, StringSplitOptions.RemoveEmptyEntries);
                    var name = parsed[0].Trim();
                    var seats = parsed[1].Split(' ');
                    var seatsCount = int.Parse(seats[1]);
                    town.Students = new List<Student>();
                    town.Name = name;
                    town.SeatsCount = seatsCount;
                    towns.Add(town);
                }
                else
                {
                    var student = new Student();
                    var parsed = inputLine.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                    var name = parsed[0].Trim();
                    var email = parsed[1].Trim();
                    var date = parsed[2].Trim();

                    DateTime datetime = DateTime.ParseExact(date, "d-MMM-yyyy", CultureInfo.InvariantCulture);
                    student.Email = email;
                    student.Name = name;
                    student.RegistrationDate = datetime;

                    Town lastTown = towns.Last();
                    lastTown.Students.Add(student);
                }
            }

            return towns;
        }
    }
}