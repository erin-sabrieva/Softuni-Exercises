using System;
using System.Collections.Generic;
using System.Linq;

namespace Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string words = Console.ReadLine();
            while (words!="end")
            {
                string[] input = words.Split();
                Box box = new Box
                {
                    SerialNumber = input[0],
                    Item = new Item
                    {
                        Name = input[1],
                        Price = decimal.Parse(input[3])
                    },
               ItemQuantity=int.Parse(input[2])
                };
                boxes.Add(box);
                words = Console.ReadLine();
            }
            List<Box> orderedBox = boxes.OrderByDescending(box => box.Price).ToList();
            foreach (Box box in orderedBox)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.Price:f2}");
            }
        }
    }
    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal Price
        {
            get
            {
                return this.ItemQuantity * this.Item.Price;
            }
        }
    }
}
