using System;
using System.Collections.Generic;

namespace _03.Need_For_Speed_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>();

            int carCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carCount; i++)
            {
                string[] currCarInfo = Console.ReadLine().Split("|");

                var newCar = new Car(currCarInfo[0], int.Parse(currCarInfo[1]), int.Parse(currCarInfo[2]));
                carList.Add(newCar);
            }


            string[] command = Console.ReadLine().Split(" : ");
            while (command[0] != "Stop")
            {
                switch (command[0])
                {
                    case "Drive":
                        DriveCar(carList, command);
                        break;
                    case "Refuel":
                        RefuelCar(carList, command);
                        break;
                    case "Revert":
                        RevertCar(carList, command);
                        break;
                }
                command = Console.ReadLine().Split(" : ");
            }

            foreach (var car in carList)
            {
                Console.WriteLine($"{car.Name} -> Mileage: {car.Milage} kms, Fuel in the tank: {car.Fuel} lt.");
            }
        }

        private static void RevertCar(List<Car> carList, string[] command)
        {
            string carName = command[1];
            int milageToRevert = int.Parse(command[2]);

            var carToRevert = carList.Find(car => car.Name == carName);

            carToRevert.Milage -= milageToRevert;

            if (carToRevert.Milage < 10000)
            {
                carToRevert.Milage = 10000;
            }

            Console.WriteLine($"{carName} mileage decreased by {milageToRevert} kilometers");
        }

        private static void RefuelCar(List<Car> carList, string[] command)
        {
            string carName = command[1];
            int fuelToIncrease = int.Parse(command[2]);
            var carToRefil = carList.Find(car => car.Name == carName);

            int originalFuel = carToRefil.Fuel;
            
            carToRefil.Fuel += fuelToIncrease;
            if (carToRefil.Fuel > 75)
            {
                carToRefil.Fuel = 75;
            }
           
            Console.WriteLine($"{carName} refueled with {carToRefil.Fuel - originalFuel} liters");
        }

        private static void DriveCar(List<Car> carList, string[] command)
        {
            string carName = command[1];            
            int milageToIncrease = int.Parse(command[2]);
            int fuelToDecrease = int.Parse(command[3]);

            var carToDrive = carList.Find(car => car.Name == carName);

            if (carToDrive.Fuel - fuelToDecrease >= 0)
            {
                carToDrive.Fuel -= fuelToDecrease;
                carToDrive.Milage += milageToIncrease;

                Console.WriteLine($"{carName} driven for {milageToIncrease} kilometers. {fuelToDecrease} liters of fuel consumed.");

                if (carToDrive.Milage >= 100000)
                {
                    carList.Remove(carToDrive);
                    Console.WriteLine($"Time to sell the {carName}!");
                }
            }
            else
            {
                Console.WriteLine("Not enough fuel to make that ride");
            }
        }
    }

    class Car
    {
        public Car(string name, int milage, int fuel)
        {
            Name = name;
            Milage = milage;
            Fuel = fuel;
        }

        public string Name { get; set; }
        public int Milage { get; set; }
        public int Fuel { get; set; }
    }
}
