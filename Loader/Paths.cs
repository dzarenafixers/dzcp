namespace DZCP.Loader
{
    using System;
    using System.Reflection;

    /// <summary>
    /// Contains the extensions to get a path.
    /// </summary>
    public static class PathExtensions
    {
        /// <summary>
        /// Gets the path of an assembly.
        /// </summary>
        /// <param name="assembly">The <see cref="Assembly"/>.</param>
        /// <exception cref="ArgumentNullException">The provided assembly is <see langword="null"/>.</exception>
        /// <returns>The path of the assembly or <see langword="null"/> if not found.</returns>
        public static string GetPath(this Assembly assembly)
        {
            if (assembly is null)
                throw new ArgumentNullException(nameof(assembly));

            // Attempt to get the path from the DZCP assembly locations dictionary.
            if (Loader.AssemblyLocations.TryGetValue(assembly, out string path))
                return path;

            // Return null if the assembly path is not found.
            return null;
        }

        /// <summary>
        /// Gets the path of a plugin.
        /// </summary>
        /// <param name="plugin">The plugin instance.</param>
        /// <exception cref="ArgumentNullException">The provided plugin is <see langword="null"/>.</exception>
        /// <returns>The path of the plugin or <see langword="null"/> if not found.</returns>
        public static string GetPath(this IPlugin plugin)
        {
            if (plugin is null)
                throw new ArgumentNullException(nameof(plugin));

            // Get the path of the plugin's assembly.
            return plugin.Assembly.GetPath();
        }

        /// <summary>
        /// Gets the path of a plugin from a custom source.
        /// </summary>
        /// <param name="plugin">The plugin instance.</param>
        /// <param name="customSource">A custom source dictionary to retrieve the path from.</param>
        /// <exception cref="ArgumentNullException">The provided plugin or custom source is <see langword="null"/>.</exception>
        /// <returns>The path of the plugin or <see langword="null"/> if not found.</returns>
        public static string GetPath(this IPlugin plugin, System.Collections.Generic.IDictionary<Assembly, string> customSource)
        {
            if (plugin is null)
                throw new ArgumentNullException(nameof(plugin));

            if (customSource is null)
                throw new ArgumentNullException(nameof(customSource));

            // Attempt to get the path from the custom source.
            if (customSource.TryGetValue(plugin.Assembly, out string path))
                return path;

            // Return null if the plugin path is not found in the custom source.
            return null;
        }
    }

    /// <summary>
    /// Represents a plugin interface.
    /// </summary>
    public interface IPlugin
    {
        /// <summary>
        /// Gets the assembly of the plugin.
        /// </summary>
        Assembly Assembly { get; }

        object Priority { get; set; }
    }

    /// <summary>
    /// Represents the loader class.
    /// </summary>
    public static class Loader
    {
        /// <summary>
        /// A dictionary containing assembly locations.
        /// </summary>
        public static System.Collections.Generic.Dictionary<Assembly, string> AssemblyLocations { get; } =
            new System.Collections.Generic.Dictionary<Assembly, string>();
    }
}