using System;

namespace _15._Drawing_Tool
{
    class Program
    {
        static void Main(string[] args)
        {
            var shape = Console.ReadLine();
            var width = double.Parse(Console.ReadLine());
            double height;

            if (shape == "Square")
            {
                height = width;
            }
            else
            {
                height = double.Parse(Console.ReadLine());
            }

            var figure = new FigDraw(width, height);
            Console.WriteLine(figure.Draw());
        }
    }
}
