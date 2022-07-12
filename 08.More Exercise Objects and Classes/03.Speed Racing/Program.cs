using System;
using System.Collections.Generic;

namespace _03.Speed_Racing
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

                Car currCar = new Car(carInfo[0], decimal.Parse(carInfo[1]), decimal.Parse(carInfo[2]));
                cars.Add(currCar);
            }

            string[] command = Console.ReadLine().Split();
            while (command[0] != "End")
            {
                string modelToDrive = command[1];
                int kmToDrive = int.Parse(command[2]);

                Car carToDrive = cars.Find(car => car.Model == modelToDrive);
                if (carToDrive.IsEnougFuel(kmToDrive))
                {
                    carToDrive.MoveCar(kmToDrive);
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
                command = Console.ReadLine().Split();
            }
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }

    class Car
    {
        public Car(string model, decimal fuelAmount, decimal fuelPerKm)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelPerKm = fuelPerKm;
            TraveledDistance = 0;
        }

        public string Model { get; set; }
        public decimal FuelAmount { get; set; }
        public decimal FuelPerKm { get; set; }
        public int TraveledDistance { get; set; }

        public bool IsEnougFuel(int kmToDrive)
        {
            bool isEnougFuel = true;

            decimal requiredFuel = kmToDrive * this.FuelPerKm;

            if (requiredFuel > FuelAmount)
            {
                isEnougFuel = false;
            }

            return isEnougFuel;
        }
        public void MoveCar(int kmToDrive)
        {
            decimal requiredFuel = kmToDrive * this.FuelPerKm;

            this.FuelAmount -= requiredFuel;
            this.TraveledDistance += kmToDrive;
        }

        public override string ToString()
        {

            return $"{Model} {FuelAmount:f2} {TraveledDistance}";
        }
    }
}
