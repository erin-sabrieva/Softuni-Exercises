using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            string words = Console.ReadLine();
            while (words!="end")
            {
                string[] input = words.Split("/");
                if (input[0]== "Car")
                {
                    Car car = new Car
                    {
                        Brand = input[1],
                        Model = input[2],
                        HorsePower = int.Parse(input[3])
                        
                    };
                    catalog.Cars.Add(car);
                }
                else
                {
                    Truck truck = new Truck
                    {
                        Brand = input[1],
                        Model=input[2],
                        Weight=int.Parse(input[3])

                    };
                    catalog.Trucks.Add(truck);
                }
                words = Console.ReadLine();
            }
            if (catalog.Cars.Count>0)
            {
                Console.WriteLine("Cars:");
                List<Car> orderedCar = catalog.Cars.OrderBy(c => c.Brand).ToList();
                foreach (var car in orderedCar)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalog.Trucks.Count>0)
            {
                Console.WriteLine("Trucks:");
                List<Truck> orderedTruck = catalog.Trucks.OrderBy(t => t.Brand).ToList();
                foreach (var truck in orderedTruck)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    class Catalog
    {
        public Catalog()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
}
