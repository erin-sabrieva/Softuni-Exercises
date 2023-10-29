using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
   public class Parking
    {
        private int capacity;
        private Dictionary<string, Car> cars = new Dictionary<string, Car>();

        public Parking(int capacity)
        {
            this.capacity = capacity;
            this.cars = new Dictionary<string, Car>();
        }
        public int Count { get { return this.cars.Count; } }

        public string AddCar(Car car)
        {
            if (this.cars.ContainsKey(car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            if (this.cars.Count== this.capacity)
            {
                return "Parking is full!";
            }
            this.cars.Add(car.RegistrationNumber,car);
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }

        
        public string RemoveCar(string registartionNumber)
        {
            if (this.cars.ContainsKey(registartionNumber))
            {
                return "Car with that registration number, doesn't exist!";
            }
            this.cars.Remove(registartionNumber);
            return $"Successfully removed {registartionNumber}";
           
        }
        public Car GetCar(string registrationNumber)
        {
            return this.cars[registrationNumber];
        }
        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var item in registrationNumbers)
            {
                this.RemoveCar(item);
            }
        }
    }
}
