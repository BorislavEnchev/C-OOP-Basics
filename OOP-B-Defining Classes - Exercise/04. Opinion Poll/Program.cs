using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Opinion_Poll
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                var person = new Person(input[0], int.Parse(input[1]));
                people.Add(person);
            }

            people = people.Where(p => p.Age > 30).OrderBy(p => p.Name).ToList();

            foreach (var person in people)
            {
                Console.WriteLine(person.Name + " - " + person.Age);
            }
        }
    }
}
