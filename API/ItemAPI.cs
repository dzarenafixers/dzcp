using System;
using System.Collections.Generic;
using DZCP.Logging;

namespace DZCP.API
{
    public static class ItemAPI
    {
        private static readonly Dictionary<string, string> Items = new Dictionary<string, string>
        {
            { "Medkit", "Heals the player." },
            { "Ammo", "Provides ammunition for weapons." },
            { "Grenade", "Explosive device." },
            { "Keycard", "Access card for restricted areas." },
            { "SCP-268", "Invisibility hat." },
            { "SCP-500", "Cures all ailments." }
        };

        private static readonly List<string> SpawnedItems = new List<string>();

        public static void SpawnItem(string itemName, string location)
        {
            if (Items.ContainsKey(itemName))
            {
                SpawnedItems.Add(itemName);
                Console.WriteLine($"[ItemAPI] Spawned {itemName} at {location}.");
                Logger.Info("ItemAPI", $"Spawned {itemName} at {location}.");
            }
            else
            {
                Console.WriteLine($"[ItemAPI] Item '{itemName}' does not exist.");
                Logger.Warn("ItemAPI", $"Item '{itemName}' does not exist.");
            }
        }

        public static void RemoveItem(string itemName)
        {
            if (SpawnedItems.Contains(itemName))
            {
                SpawnedItems.Remove(itemName);
                Console.WriteLine($"[ItemAPI] Removed {itemName}.");
                Logger.Info("ItemAPI", $"Removed {itemName}.");
            }
            else
            {
                Console.WriteLine($"[ItemAPI] Item '{itemName}' not found.");
                Logger.Warn("ItemAPI", $"Item '{itemName}' not found.");
            }
        }

        public static void ListItems()
        {
            Console.WriteLine("[ItemAPI] Available items:");
            Logger.Info("ItemAPI", "Available items:");
            foreach (var item in Items)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
                Logger.Info("ItemAPI", $"{item.Key}: {item.Value}");
            }
        }

        public static void ClearAllItems()
        {
            SpawnedItems.Clear();
            Console.WriteLine("[ItemAPI] All items cleared.");
            Logger.Info("ItemAPI", "All items cleared.");
        }
    }
}