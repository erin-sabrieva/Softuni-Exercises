using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] propeties = Console.ReadLine().Split();
                Car car = new Car(
                    propeties[0],int.Parse(propeties[1]), int.Parse(propeties[2]), int.Parse(propeties[3])
                    , propeties[4], double.Parse(propeties[5]), int.Parse(propeties[6]), double.Parse(propeties[7])
                    , int.Parse(propeties[8]), double.Parse(propeties[9]), int.Parse(propeties[10]), double.Parse(propeties[11])
                    , int.Parse(propeties[12]));
                cars.Add(car);
            }
            string word = Console.ReadLine();
            string[] carModels;
            if (word== "fragile")
            {
                carModels = cars.Where(c=>c.Cargo.Type== "fragile"&& c.Tires.Any(c=>c.Pressure<1)).Select(m=>m.Model).ToArray();
            }
            else
            {
                carModels = cars.Where(c => c.Cargo.Type == "flammable" && c.Engine.Power>250).Select(m => m.Model).ToArray();
            }
            foreach (var item in carModels)
            {
                Console.WriteLine(item);
            }
        }
    }
}
