using System;
using System.Collections.Generic;

namespace _03._Oldest_Family_Member
{
    class Program
    {
        static void Main(string[] args)
        {
            var family = new Family();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                var person = new Person(input[0], int.Parse(input[1]));
                family.AddMember(person);
            }

            var oldestMember = family.GetOldestMember();

            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}
