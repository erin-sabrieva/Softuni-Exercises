using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
   public class Car
    {
        public Car(string model, int speed, int power,int weight, string type, double pressure1, int age1, double pressure2, int age2, double pressure3, int age3, double pressure4, int age4)
        {
            Model = model;
            Engine = new Engine { Power=power,Speed=speed};
            Cargo = new Cargo {Type=type,Weight=weight };
            Tires = new Tires[4];
            Tires[0] = new Tires { Pressure = pressure1, Age = age1 };
            Tires[1] = new Tires { Pressure = pressure2, Age = age2 };
            Tires[2] = new Tires { Pressure = pressure3, Age = age3 };
            Tires[3] = new Tires { Pressure = pressure4, Age = age4 };
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tires[] Tires { get; set; }
    }
}
