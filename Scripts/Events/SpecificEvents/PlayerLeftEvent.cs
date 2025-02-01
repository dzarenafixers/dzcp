using System;

namespace SCPSL_Framework.Scripts.Events.SpecificEvents
{
    public class PlayerLeftEvent : EventManager
    {
        public string PlayerName { get; set; }

        public PlayerLeftEvent(string playerName)
            : base("PlayerLeft")
        {
            PlayerName = playerName;
        }

        public void Trigger()
        {
            // Implement the logic for when a player leaves the game
            Console.WriteLine($"{PlayerName} has left the game.");
        }
    }
}