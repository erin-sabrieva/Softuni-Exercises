using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            List<Vehicle> all = new List<Vehicle>();
            while (words!="End")
            {
                string[] input = words.Split(" ");
                VehicleType vehicleType;
                bool IsSuccessful = Enum.TryParse(input[0], true, out vehicleType);
                if (IsSuccessful)
                {
                    string model = input[1];
                    string colour = input[2];
                    int horsePower = int.Parse(input[3]);
                    var currVehicle = new Vehicle(vehicleType,model,colour,horsePower);
                    all.Add(currVehicle);
                }
                words = Console.ReadLine();
            }
            string line = Console.ReadLine();
            while (line!= "Close the Catalogue")
            {
                var desiredVehicle = all.FirstOrDefault(vehicle => vehicle.Model==line);
                Console.WriteLine(desiredVehicle);
                line = Console.ReadLine();
            }
            var cars = all.Where(vehicles => vehicles.Type== VehicleType.Car).ToList();
            var trucks = all.Where(vehicles => vehicles.Type == VehicleType.Truck).ToList();
            double averageCars = cars.Count > 0 ? cars.Average(car => car.HorsePower) : 0.00;
            double averageTrucks = trucks.Count > 0 ? trucks.Average(truck => truck.HorsePower) : 0.00;
            Console.WriteLine($"Cars have average horsepower of: {averageCars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTrucks:f2}.");

        }
    }
    enum VehicleType
    {
        Car,
        Truck
    }
    class Vehicle
    {
        public Vehicle(VehicleType type, string model, string colour, int horsePower)
        {
            Type = type;
            Model = model;
            Colour = colour;
            HorsePower = horsePower;
        }
        public VehicleType Type { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public int HorsePower { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Type: {Type}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Colour}");
            sb.AppendLine($"Horsepower: {HorsePower}");
            return sb.ToString().TrimEnd();
        }
        
        
    }
}
