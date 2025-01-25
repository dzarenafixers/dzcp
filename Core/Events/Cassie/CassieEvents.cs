using System;

namespace سست.Core.Event.Cassie
{
    public static class CassieEvents
    {
        public static void OnAnnouncement(string message)
        {
            Console.WriteLine($"Cassie announces: {message}");
        }

        public static void OnCustomAnnouncement(string message, bool isNoisy)
        {
            string noisyText = isNoisy ? " (Noisy)" : "";
            Console.WriteLine($"Cassie announces: {message}{noisyText}");
        }
    }
}