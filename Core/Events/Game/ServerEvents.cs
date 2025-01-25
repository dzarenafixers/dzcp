using System;

namespace سست.Core.Event.Game
{
    public static class ServerEvents
    {
        public static void OnServerStart()
        {
            Console.WriteLine("Server has started!");
        }

        public static void OnServerStop()
        {
            Console.WriteLine("Server has stopped!");
        }
    }
}