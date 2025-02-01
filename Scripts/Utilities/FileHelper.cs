using System;
using System.IO;

namespace SCPSL_Framework.Utilities
{
    public static class FileHelper
    {
        public static string ReadFile(string filePath)
        {
            try
            {
                return File.ReadAllText(filePath);
            }
            catch (Exception ex)
            {
                Logger.LogError($"Failed to read file: {filePath}. Exception: {ex.Message}");
                throw;
            }
        }

        public static void WriteFile(string filePath, string content)
        {
            try
            {
                File.WriteAllText(filePath, content);
            }
            catch (Exception ex)
            {
                Logger.LogError($"Failed to write file: {filePath}. Exception: {ex.Message}");
                throw;
            }
        }
    }
}