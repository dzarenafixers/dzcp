using System;

namespace DZCP.Core
{
    public static class EventManager
    {
        public static event Action<string> OnPlayerJoin;
        public static event Action<string> OnPlayerLeave;
        public static event Action<string> OnSCPDeath;
        public static event Action<string, string> OnItemPickup;

        public static void TriggerPlayerJoin(string playerName)
        {
            OnPlayerJoin?.Invoke(playerName);
        }

        public static void TriggerPlayerLeave(string playerName)
        {
            OnPlayerLeave?.Invoke(playerName);
        }

        public static void TriggerSCPDeath(string scpName)
        {
            OnSCPDeath?.Invoke(scpName);
        }

        public static void TriggerItemPickup(string playerName, string itemName)
        {
            OnItemPickup?.Invoke(playerName, itemName);
        }
    }
}