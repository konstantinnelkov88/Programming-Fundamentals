using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = Console.ReadLine();
            string lname = Console.ReadLine();
            sbyte age = sbyte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long PersonalID = long.Parse(Console.ReadLine());
            int Employenumber = int.Parse(Console.ReadLine());
			
            Console.WriteLine("First name: {0}", fname);
            Console.WriteLine("Last name: {0}", lname);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}", PersonalID);
            Console.WriteLine("Unique Employee number: {0}", Employenumber);
        }
    }
}