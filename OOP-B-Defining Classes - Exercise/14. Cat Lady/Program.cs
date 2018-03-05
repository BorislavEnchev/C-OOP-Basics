using System;
using System.Collections.Generic;
using System.Linq;

namespace _14._Cat_Lady
{
    class Program
    {
        static void Main(string[] args)
        {
            var cats = GetCats();
            PrintCat(cats);
        }

        private static void PrintCat(List<Cat> cats)
        {
            var catToPrint = Console.ReadLine();
            var exactCat = cats.FirstOrDefault(c => c.Name == catToPrint);
            Console.WriteLine(exactCat.ToString());
        }

        private static List<Cat> GetCats()
        {
            var cats = new List<Cat>();
            var input = Console.ReadLine().Split();
            
            while (input[0] != "End")
            {
                var breed = input[0];
                var name = input[1];
                var characteristic = double.Parse(input[2]);
                var cat = new Cat(breed, name, characteristic);
                cats.Add(cat);

                input = Console.ReadLine().Split();
            }
            return cats;
        }
    }
}
