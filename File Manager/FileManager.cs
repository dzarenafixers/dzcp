using System;
using System.IO;

namespace PluginFramework
{
    public static class FileManager
    {
        private static readonly string DataDirectory = "Data";

        static FileManager()
        {
            if (!Directory.Exists(DataDirectory))
            {
                Directory.CreateDirectory(DataDirectory);
            }
        }

        public static void SaveData(string fileName, string content)
        {
            string filePath = Path.Combine(DataDirectory, fileName);
            File.WriteAllText(filePath, content);
            Console.WriteLine($"[FileManager] تم حفظ البيانات في: {filePath}");
        }

        public static string LoadData(string fileName)
        {
            string filePath = Path.Combine(DataDirectory, fileName);
            return File.Exists(filePath) ? File.ReadAllText(filePath) : null;
        }
    }
}