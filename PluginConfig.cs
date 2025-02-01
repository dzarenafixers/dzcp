using System;
using System.IO;
using Newtonsoft.Json;

namespace PluginFramework
{
    public class PluginConfig<T> where T : new()
    {
        private readonly string _filePath;
        public T Settings { get; private set; }

        public PluginConfig(string fileName)
        {
            _filePath = Path.Combine("Configs", fileName);
            Load();
        }

        private void Load()
        {
            if (!File.Exists(_filePath))
            {
                Settings = new T();
                Save();
            }
            else
            {
                Settings = JsonConvert.DeserializeObject<T>(File.ReadAllText(_filePath));
            }
        }

        public void Save()
        {
            File.WriteAllText(_filePath, JsonConvert.SerializeObject(Settings, Formatting.Indented));
        }
    }
}