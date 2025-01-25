using System;

namespace سست.Logging
{
    public static class Log
    {
        public static void Info(string message)
        {
            Console.WriteLine($"[INFO] {message}");
        }
    }
}