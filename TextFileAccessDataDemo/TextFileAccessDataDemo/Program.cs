using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextFileAccessDataDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\JYEP\source\repos\Basic_Exercises\Test.txt";

            //List<string> lines = File.ReadAllLines(filePath).ToList();

            //foreach (string line in lines)
            //{
            //    Console.WriteLine(line);
            //}

            //lines.Add("Jenny, Trial, www.website.com");

            //File.WriteAllLines(filePath, lines);

            List<Person> people = new List<Person>();

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split(',');

                Person newPerson = new Person();

                newPerson.FirstName = entries[0];
                newPerson.LastName = entries[1];
                newPerson.Url = entries[2];

                people.Add(newPerson);
            }

            Console.WriteLine("read from text file");
            foreach (var person in people)
            {
                // Same as below but slower -> person.FirstName + " " + person.LastName + ": " + person.Url
                Console.WriteLine($"{ person.FirstName} { person.LastName} : { person.Url}");
            }

            people.Add(new Person { FirstName = "Han", LastName = "Solo", Url = "www.starwars.com" });

            List<string> output = new List<string>();

            foreach (var person in people)
            {   // List of string output
                output.Add($"{ person.FirstName},{ person.LastName},{ person.Url}");
            }

            Console.WriteLine("Writing to text file");

            File.WriteAllLines(filePath, output);

            Console.WriteLine("All entries written");

            Console.ReadLine();
        }
    }
}
