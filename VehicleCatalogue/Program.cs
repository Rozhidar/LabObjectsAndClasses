using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string input;

        while ((input = Console.ReadLine()) != "end")
        {
            string[] inputData = input.Split("/");

            string type = inputData[0];
            string brand = inputData[1];
            string model = inputData[2];

            if (type == "Car")
            {
                int horsePower = int.Parse(inputData[3]);
                Car car = new Car(brand, model, horsePower);
                CatalogVehicle.Cars.Add(car);
            }
            else if (type == "Truck")
            {
                int loadCapacity = int.Parse(inputData[3]);
                Truck truck = new Truck(brand, model, loadCapacity);
                CatalogVehicle.Trucks.Add(truck);
            }
        }

        Console.WriteLine("Cars:");
        foreach (var car in CatalogVehicle.Cars.OrderBy(c => c.Brand))
        {
            Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
        }

        Console.WriteLine("Trucks:");
        foreach (var truck in CatalogVehicle.Trucks.OrderBy(t => t.Brand))
        {
            Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.LoadCapacity}kg");
        }
    }
}

public class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }

    public Vehicle(string brand, string model)
    {
        Brand = brand;
        Model = model;
    }
}

public class Car : Vehicle
{
    public int HorsePower { get; set; }

    public Car(string brand, string model, int horsePower)
        : base(brand, model)
    {
        HorsePower = horsePower;
    }
}

public class Truck : Vehicle
{
    public int LoadCapacity { get; set; }

    public Truck(string brand, string model, int loadCapacity)
        : base(brand, model)
    {
        LoadCapacity = loadCapacity;
    }
}

public class CatalogVehicle
{
    public static List<Car> Cars { get; set; } = new List<Car>();
    public static List<Truck> Trucks { get; set; } = new List<Truck>();
}
