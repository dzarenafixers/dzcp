using System;

namespace سست.Core.Event.Interfaces
{
    public static class EventManager
    {
        public static void TriggerEvent(IEvent eventObj)
        {
            if (eventObj == null)
                throw new ArgumentNullException(nameof(eventObj));

            eventObj.Execute();


            void TriggerRoundStart()
        {
            Game.RoundEvents.OnRoundStart();
        }

            void TriggerRoundEnd()
        {
            Game.RoundEvents.OnRoundEnd();
        }

            void TriggerCassieAnnouncement(string message)
        {
            Cassie.CassieEvents.OnAnnouncement(message);
        }
    }
 
    }
}