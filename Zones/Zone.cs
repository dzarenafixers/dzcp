using System;
using System.Collections.Generic;

namespace سست.Zones
{
    public static class ZoneManager
    {
        private static Dictionary<string, List<Player>> playersInZones = new Dictionary<string, List<Player>>();

        public static void Initialize()
        {
            // تهيئة القوائم لكل منطقة
            playersInZones["LightContainment"] = new List<Player>();
            playersInZones["HeavyContainment"] = new List<Player>();
            playersInZones["Entrance"] = new List<Player>();

            Console.WriteLine("تم تفعيل مدير المناطق.");
        }

        public static void AddPlayerToZone(Player player, string zone)
        {
            if (playersInZones.ContainsKey(zone))
            {
                playersInZones[zone].Add(player);
                Console.WriteLine($"تمت إضافة اللاعب {player.Name} إلى منطقة {zone}.");
            }
            else
            {
                Console.WriteLine("المنطقة غير موجودة.");
            }
        }

        public static void RemovePlayerFromZone(Player player, string zone)
        {
            if (playersInZones.ContainsKey(zone))
            {
                playersInZones[zone].Remove(player);
                Console.WriteLine($"تمت إزالة اللاعب {player.Name} من منطقة {zone}.");
            }
            else
            {
                Console.WriteLine("المنطقة غير موجودة.");
            }
        }

        public static List<Player> GetPlayersInZone(string zone)
        {
            if (playersInZones.ContainsKey(zone))
            {
                return playersInZones[zone];
            }
            return new List<Player>();
        }

        public static void DisplayZoneInfo()
        {
            foreach (var zone in playersInZones.Keys)
            {
                Console.WriteLine($"المنطقة: {zone}, عدد اللاعبين: {playersInZones[zone].Count}");
            }
        }
    }
}