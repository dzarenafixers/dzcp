using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace SCPSL_Framework.Utilities
{
    public static class ConfigManager
    {
        private static readonly string configDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Configs");

        public static T LoadConfig<T>(string configName)
        {
            string configPath = Path.Combine(configDirectory, $"{configName}.json");

            if (!File.Exists(configPath))
            {
                Logger.LogError($"Config file not found: {configPath}");
                throw new FileNotFoundException($"Config file not found: {configPath}");
            }

            try
            {
                string configContent = File.ReadAllText(configPath);
                return JsonConvert.DeserializeObject<T>(configContent);
            }
            catch (Exception ex)
            {
                Logger.LogError($"Failed to load config: {configPath}. Exception: {ex.Message}");
                throw;
            }
        }

        public static void SaveConfig<T>(string configName, T config)
        {
            string configPath = Path.Combine(configDirectory, $"{configName}.json");

            try
            {
                string configContent = JsonConvert.SerializeObject(config, Formatting.Indented);
                File.WriteAllText(configPath, configContent);
            }
            catch (Exception ex)
            {
                Logger.LogError($"Failed to save config: {configPath}. Exception: {ex.Message}");
                throw;
            }
        }
    }
}