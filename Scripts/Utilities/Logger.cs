using System;
using System.IO;

namespace SCPSL_Framework.Utilities
{
    public static class Logger
    {
        private static readonly string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs", "log.txt");

        static Logger()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(logFilePath));
        }

        public static void Log(string message)
        {
            string logMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}";
            Console.WriteLine(logMessage);
            File.AppendAllText(logFilePath, logMessage + Environment.NewLine);
        }

        public static void LogError(string message)
        {
            Log("ERROR: " + message);
        }

        public static void LogWarning(string message)
        {
            Log("WARNING: " + message);
        }

        public static void LogInfo(string message)
        {
            Log("INFO: " + message);
        }
    }
}