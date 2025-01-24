using System;
using System.Collections.Generic;
using DZCP.Logging;

namespace DZCP.Core
{
    public static class PluginManager
    {
        public static Version Version => new Version(14, 0, 2);
        private static List<IDZCPPlugin> _plugins = new List<IDZCPPlugin>();

        public static void RegisterPlugin(IDZCPPlugin plugin)
        {
            _plugins.Add(plugin);
            plugin.OnEnabled();
            Logger.Info("PluginManager", $"{plugin.GetType().Name} has been enabled!");
        }

        public static void UnregisterPlugins()
        {
            foreach (var plugin in _plugins)
            {
                plugin.OnDisabled();
                Logger.Info("PluginManager", $"{plugin.GetType().Name} has been disabled!");
            }
            _plugins.Clear();
        }
    }

    public interface IDZCPPlugin
    {
        void OnEnabled();
        void OnDisabled();
    }
}