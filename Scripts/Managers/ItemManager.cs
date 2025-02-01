using System;
using System.Collections.Generic;

namespace SCPSL_Framework.Managers
{
    public class ItemManager
    {
        private List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
            Console.WriteLine($"Item added: {item.Name}");
        }

        public void ListItems()
        {
            Console.WriteLine("Listing items:");
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Name} - Type: {item.Type}");
            }
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Dictionary<string, int> Attributes { get; set; }

        public Item(string name, string type, Dictionary<string, int> attributes)
        {
            Name = name;
            Type = type;
            Attributes = attributes;
        }
    }
}