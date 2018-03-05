using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Speed_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            var carsToTrack = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < carsToTrack; i++)
            {
                var input = Console.ReadLine().Split();
                var model = input[0];
                var fuel = double.Parse(input[1]);
                var consumption = double.Parse(input[2]);
                cars.Add(new Car(model, fuel, consumption));
            }
            DriveCars(cars);
            PrintCars(cars);
        }

        private static void PrintCars(List<Car> cars)
        {
            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.DistanceTraveled}");
            }
        }

        private static void DriveCars(List<Car> cars)
        {
            var command = Console.ReadLine().Split();
            
            while (command[0] != "End")
            {
                var model = command[1];
                var distance = double.Parse(command[2]);

                var car = cars.Where(c => c.Model == model).FirstOrDefault();

                if (car != null)
                {
                    car.Drive(distance);
                }
                command = Console.ReadLine().Split();
            }
        }
    }
}
