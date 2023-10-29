using System;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var orders = new Dictionary<string, double>();
            var newOrders = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input!="buy")
            {
                string[] command = input.Split();
                string productName = command[0];
                double productPrice = double.Parse(command[1]);
                int productQuantity = int.Parse(command[2]);
                if (!orders.ContainsKey(productName))
                {
                    orders.Add(productName, productPrice);
                    newOrders.Add(productName, productQuantity);
                }
                else if (orders.ContainsKey(productName))
                {
                    orders.Remove(productName);
                    orders.Add(productName, productPrice);
                    newOrders[productName] += productQuantity;
                }

                input = Console.ReadLine();
            }
            foreach (var order in orders)
            {
                foreach (var newOrder in newOrders)
                {
                    if (order.Key== newOrder.Key)
                    {
                        Console.WriteLine($"{newOrder.Key} -> {(order.Value * newOrder.Value):f2}");
                    }
                }
            }
            
        }
    }
}
