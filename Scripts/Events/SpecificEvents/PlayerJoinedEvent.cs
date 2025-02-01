using System;

namespace SCPSL_Framework.Scripts.Events.SpecificEvents
{
    public class PlayerJoinedEvent : EventManager
    {
        public string PlayerName { get; set; }
        public string EventName { get; set; }

        public PlayerJoinedEvent(string playerName)
            : base("PlayerJoined")
        {
            PlayerName = playerName;
        }

        public void Trigger()
        {
            // Implement the logic for when a player joins the game
            Console.WriteLine($"{PlayerName} has joined the game!");
        }
    }
}