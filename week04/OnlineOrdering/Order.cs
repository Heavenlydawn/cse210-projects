using System;
using System.Collections.Generic;

namespace OnlineOrderingProgram.Models
{
    public class Order
    {
        private List<Item> items;

        public Order()
        {
            items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void RemoveItem(string itemName)
        {
            items.RemoveAll(i => i.Name.ToLower() == itemName.ToLower());
        }

        public double CalculateTotal()
        {
            double total = 0;
            foreach (var item in items)
            {
                total += item.GetTotalPrice();
            }
            return total;
        }

        public void DisplayOrder()
        {
            Console.WriteLine("Order Summary:");
            foreach (var item in items)
            {
                item.DisplayItem();
            }
            Console.WriteLine($"Total Cost: ${CalculateTotal():F2}");
            Console.WriteLine("---------------------------");
        }
    }
}
