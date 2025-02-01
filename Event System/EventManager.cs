using System;
using System.Collections.Generic;

namespace PluginFramework
{
    public static class EventManager
    {
        private static readonly Dictionary<string, List<IEventListener>> Listeners = new Dictionary<string, List<IEventListener>>();

        public static void RegisterListener(string eventName, IEventListener listener)
        {
            if (string.IsNullOrEmpty(eventName))
            {
                Logger.Log("❌ [EventManager] فشل تسجيل المستمع: اسم الحدث فارغ أو غير صالح!");
                return;
            }

            if (!Listeners.ContainsKey(eventName))
            {
                Listeners[eventName] = new List<IEventListener>();
            }

            Listeners[eventName].Add(listener);
            Logger.Log($"✅ [EventManager] تم تسجيل مستمع جديد للحدث: {eventName}");
        }

        public static void TriggerEvent(string eventName, object eventData = null)
        {
            if (string.IsNullOrEmpty(eventName))
            {
                Logger.Log("❌ [EventManager] محاولة تشغيل حدث باسم غير صالح!");
                return;
            }

            if (Listeners.ContainsKey(eventName))
            {
                Logger.Log($"🔔 [EventManager] تشغيل الحدث: {eventName}");
                foreach (var listener in Listeners[eventName])
                {
                    listener.OnEventTriggered(eventName, eventData);
                }
            }
        }
    }
}