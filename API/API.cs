using System;
using System.Collections.Generic;
using سست.API;
using سست.Loader;

namespace DZCP.API
{
    /// <summary>
    /// Provides the implementation of the DZCP API.
    /// </summary>
    public class Api : IApi
    {
        private readonly List<string> _loadedPlugins = new List<string>();
        private IConfig _config;

        /// <inheritdoc />
        public string Version => "1.0.0";

        /// <inheritdoc />
        public void Initialize(IConfig config)
        {
            _config = config ?? throw new ArgumentNullException(nameof(config));
            Console.WriteLine("API initialized with config.");
        }

        /// <inheritdoc />
        public bool LoadPlugin(string pluginName)
        {
            if (string.IsNullOrEmpty(pluginName))
                throw new ArgumentException("Plugin name cannot be null or empty.", nameof(pluginName));

            if (_loadedPlugins.Contains(pluginName))
            {
                Console.WriteLine($"Plugin '{pluginName}' is already loaded.");
                return false;
            }

            // Simulate plugin loading
            _loadedPlugins.Add(pluginName);
            Console.WriteLine($"Plugin '{pluginName}' loaded successfully.");
            return true;
        }

        /// <inheritdoc />
        public bool UnloadPlugin(string pluginName)
        {
            if (string.IsNullOrEmpty(pluginName))
                throw new ArgumentException("Plugin name cannot be null or empty.", nameof(pluginName));

            if (!_loadedPlugins.Contains(pluginName))
            {
                Console.WriteLine($"Plugin '{pluginName}' is not loaded.");
                return false;
            }

            // Simulate plugin unloading
            _loadedPlugins.Remove(pluginName);
            Console.WriteLine($"Plugin '{pluginName}' unloaded successfully.");
            return true;
        }

        /// <inheritdoc />
        public List<string> GetLoadedPlugins()
        {
            return _loadedPlugins;
        }

        /// <inheritdoc />
        public string ExecuteCommand(string command)
        {
            if (string.IsNullOrEmpty(command))
                throw new ArgumentException("Command cannot be null or empty.", nameof(command));

            // Simulate command execution
            return $"Executed command: {command}";
        }
    }
}