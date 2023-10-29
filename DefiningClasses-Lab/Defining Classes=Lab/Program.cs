using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car()
            {
                Make = "Test",
            
             Year=1567,

            };
            Console.WriteLine(car.Make);
            Console.WriteLine(car.Year);
            

        }
    }
}
