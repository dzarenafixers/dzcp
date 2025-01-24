using System;

namespace DZCP.Logging
{
    public static class Logger
    {
        public static void Info(string source, string message)
        {
            Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} | [INFO] [{source}] {message}");
        }

        public static void Warn(string source, string message)
        {
            Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} | [WARN] [{source}] {message}");
        }

        public static void Error(string source, string message)
        {
            Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} | [ERROR] [{source}] {message}");
        }
    }
}