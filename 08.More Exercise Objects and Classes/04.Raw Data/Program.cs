using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Raw_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int carsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsCount; i++)
            {
                string[] carInfo = Console.ReadLine().Split();

                Car currCar = new Car(carInfo[0], int.Parse(carInfo[1]), int.Parse(carInfo[2]), int.Parse(carInfo[3]), carInfo[4]);
                cars.Add(currCar);
            }

            string cargoTypeRequired = Console.ReadLine();

            if (cargoTypeRequired == "fragile")
            {
                List<Car> fragileList = cars
                    .Where(car => car.Cargo.CargoType == cargoTypeRequired)
                    .Where(car => car.Cargo.CargoWeight < 1000)
                    .ToList();
                foreach (var car in fragileList)
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
            else
            {
                List<Car> flamableList = cars
                    .Where(car => car.Cargo.CargoType == cargoTypeRequired)
                    .Where(car => car.Engine.EnginePower > 250)
                    .ToList();
                foreach (var car in flamableList)
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
        }
    }

    class Car
    {
        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType)
        {
            Model = model;
            Engine = new Engine(engineSpeed, enginePower);
            Cargo = new Cargo(cargoWeight, cargoType);
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
    }
    class Engine
    {
        public Engine(int engineSpeed, int enginePower)
        {
            EngineSpeed = engineSpeed;
            EnginePower = enginePower;
        }

        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
    }

    class Cargo
    {
        public Cargo(int cargoWeight, string cargoType)
        {
            CargoWeight = cargoWeight;
            CargoType = cargoType;
        }

        public int CargoWeight { get; set; }
        public string CargoType { get; set; }
    }
}
