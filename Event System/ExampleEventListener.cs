using System;

namespace ExamplePlugin
{
    public class ExampleEventListener : PluginFramework.IEventListener
    {
        public void OnEventTriggered(string eventName, object eventData)
        {
            Console.WriteLine($"[ExampleEventListener] حدث: {eventName} - البيانات: {eventData}");
        }
    }
}