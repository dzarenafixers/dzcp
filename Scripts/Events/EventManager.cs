using System;
using System.Collections.Generic;
using SCPSL_Framework.Scripts.Events.SpecificEvents;

namespace SCPSL_Framework.Scripts.Events
{
    public class EventManager
    {
        private Dictionary<string, EventManager> events = new Dictionary<string, EventManager>();

        public EventManager(string playerjoined)
        {
            throw new NotImplementedException();
        }

        public EventManager()
        {
            throw new NotImplementedException();
        }

        public void RegisterEvent(PlayerJoinedEvent gameEvent)
        {
            if (!events.ContainsKey(gameEvent.EventName))
            {
                events.Add(gameEvent.EventName, gameEvent);
                Console.WriteLine($"Event registered: {gameEvent.EventName}");
            }
        }

        public void TriggerEvent(string eventName)
        {
            if (events.ContainsKey(eventName))
            {
                events[eventName].ToString() ;
                Console.WriteLine($"Event triggered: {eventName}");
            }
            else
            {
                Console.WriteLine($"Event not found: {eventName}");
            }
        }
    }
}