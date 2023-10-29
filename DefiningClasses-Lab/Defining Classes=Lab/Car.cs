using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
  public  class Car
    {
        private string make;
        private string model;
        private int year;

        private double fuelQuantity;

        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
           FuelConsumption=10;

        }
        public Car(string make, string model, int year) :this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;

        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption):this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        


        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }

        private double fuelConsumption;

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public string Make { get
            {
                return this.make;
            }
            set
            {
                make = value;
            }
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                model = value;
            }
        }
        public int Year
        {
            get
            {
                return this.year;
            }
            set
            {
                year = value;
            }
        }

        public void Drive(double distance)
        {
            if (fuelQuantity-(distance*fuelConsumption)>0)
            {
                fuelConsumption = distance * fuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
                return;
            }
        }
        public string WhoAmI()
        {
            return $"Make: {this.Make}\nModel: { this.Model}\n Year: { this.Year}\nFuel: { this.FuelQuantity:F2}";
        }
    }
}
