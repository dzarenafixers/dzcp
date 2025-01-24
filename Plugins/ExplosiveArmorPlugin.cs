using System;
using DZCP.Core;

namespace DZCP.Plugins
{
    public class ExplosiveArmorPlugin : IDZCPPlugin
    {
        public void OnEnabled()
        {
            Console.WriteLine("Explosive Armor Plugin Enabled!");
            EventManager.OnItemPickup += OnItemPickup;
        }

        public void OnDisabled()
        {
            Console.WriteLine("Explosive Armor Plugin Disabled!");
            EventManager.OnItemPickup -= OnItemPickup;
        }

        private void OnItemPickup(string playerName, string itemName)
        {
            if (itemName == "Half-Armor")
            {
                Console.WriteLine($"{playerName} picked up an explosive armor!");
                // تفجير الدرع بعد 30 ثانية
                System.Threading.Thread.Sleep(30000);
                Console.WriteLine($"{playerName}'s armor exploded!");
            }
        }
    }
}