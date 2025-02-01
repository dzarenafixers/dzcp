using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using HarmonyLib;
using PluginFramework;
using SCPSL_Framework.Scripts.Core ;

namespace MyFW
{
    public class Main
    {
        public static List<IPlugin> Plugins = new List<IPlugin>();

        public static void LoadPlugins()
        {
            string pluginsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "plugins");

            if (!Directory.Exists(pluginsPath))
                Directory.CreateDirectory(pluginsPath);

            foreach (string file in Directory.GetFiles(pluginsPath, "*.dll"))
            {
                try
                {
                    Assembly assembly = Assembly.LoadFrom(file);
                    foreach (Type type in assembly.GetTypes())
                    {
                        if (typeof(IPlugin).IsAssignableFrom(type) && !type.IsInterface)
                        {
                            IPlugin plugin = (IPlugin)Activator.CreateInstance(type);
                            plugin.OnLoad();
                            Plugins.Add(plugin);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading plugin {file}: {ex.Message}");
                }
            }
        }

        public static void UnloadPlugins()
        {
            foreach (IPlugin plugin in Plugins)
            {
                plugin.OnLoad();
            }
            Plugins.Clear();
        }
    }
}