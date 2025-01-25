using System;
using System.IO;
using System.Linq;
using System.Reflection;
using DZCP.Core;
using DZCP.Logging;

namespace DZCP.Loader
{
    public static class PluginLoader
    {
        public static void LoadPlugins()
        {
            string pluginsPath = Path.Combine(Directory.GetCurrentDirectory(), "Plugins");
            if (!Directory.Exists(pluginsPath))
            {
                Directory.CreateDirectory(pluginsPath);
                Logger.Info("PluginLoader", "Plugins directory created.");
                return;
            }

            var pluginFiles = Directory.GetFiles(pluginsPath, "*.dll");
            foreach (var file in pluginFiles)
            {
                try
                {
                    Assembly assembly = Assembly.LoadFrom(file);
                    var pluginTypes = assembly.GetTypes()
                        .Where(t => typeof(IDZCPPlugin).IsAssignableFrom(t) && !t.IsInterface);

                    foreach (var type in pluginTypes)
                    {
                        var plugin = Activator.CreateInstance(type) as IDZCPPlugin;
                        if (plugin != null)
                        {
                            PluginManager.RegisterPlugin(plugin);
                            Logger.Info("PluginLoader", $"Loaded plugin: {type.Name} from {file}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Logger.Error("PluginLoader", $"Failed to load plugin from {file}: {ex.Message}");
                }
            }
        }

        public static void UnloadPlugins()
        {
            PluginManager.UnregisterPlugins();
        }
    }
}