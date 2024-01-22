using System.IO;
using System;
using System.Collections.Generic;
using Course.Entities;
using System.Linq;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Employee> employees = new List<Employee>();

                Console.Write("Enter the full file path: ");
                string path = Console.ReadLine();

                Console.Write("Enter the salary: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] vect = sr.ReadLine().Split(",");
                        string name = vect[0];
                        string email = vect[1];
                        double salary = double.Parse(vect[2], CultureInfo.InvariantCulture);

                        employees.Add(new Employee(name, email, salary));
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Email of people whose salary is more than inserted: ");
                var emailList = employees.Where(e => e.Salary > value).Select(e => e.Email);

                foreach (string s in emailList)
                {
                    Console.WriteLine(s);
                }

                Console.WriteLine();
                Console.Write("Sum of salary of people whose name starts with 'M': ");
                var sum = employees.Where(e => e.Name[0] == 'M').Select(e => e.Salary).Sum();
                Console.WriteLine(sum);

            }

            catch (IOException e)
            {
                Console.WriteLine("An error occured: ");
                Console.WriteLine(e.Message);
            }

           


        }







    }
}








