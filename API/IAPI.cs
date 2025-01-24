using System.Collections.Generic;
using سست.Loader;

namespace سست.API
{
    /// <summary>
    /// Defines the API interface for DZCP.
    /// </summary>
    public interface IApi
    {
        /// <summary>
        /// Gets the version of the DZCP API.
        /// </summary>
        string Version { get; }

        /// <summary>
        /// Initializes the API with the specified configuration.
        /// </summary>
        /// <param name="config">The configuration object.</param>
        void Initialize(IConfig config);

        /// <summary>
        /// Loads a plugin by its name.
        /// </summary>
        /// <param name="pluginName">The name of the plugin.</param>
        /// <returns>True if the plugin was loaded successfully; otherwise, false.</returns>
        bool LoadPlugin(string pluginName);

        /// <summary>
        /// Unloads a plugin by its name.
        /// </summary>
        /// <param name="pluginName">The name of the plugin.</param>
        /// <returns>True if the plugin was unloaded successfully; otherwise, false.</returns>
        bool UnloadPlugin(string pluginName);

        /// <summary>
        /// Gets a list of all loaded plugins.
        /// </summary>
        /// <returns>A list of plugin names.</returns>
        List<string> GetLoadedPlugins();

        /// <summary>
        /// Executes a command through the API.
        /// </summary>
        /// <param name="command">The command to execute.</param>
        /// <returns>The result of the command execution.</returns>
        string ExecuteCommand(string command);
    }
}