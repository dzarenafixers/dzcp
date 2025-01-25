using System;

namespace سست.Plugins
{
    /// <summary>
    /// A simple example plugin for DZCP.
    /// </summary>
    public class ExamplePlugin
    {
        /// <summary>
        /// Called when the plugin is enabled.
        /// </summary>
        public void OnEnabled()
        {
            Console.WriteLine("ExamplePlugin has been enabled!");

            // Simulate waiting for players
            OnWaitingForPlayers();
        }

        /// <summary>
        /// Called when the plugin is disabled.
        /// </summary>
        public void OnDisabled()
        {
            Console.WriteLine("ExamplePlugin has been disabled!");
        }

        /// <summary>
        /// Called when the server is waiting for players.
        /// </summary>
        private void OnWaitingForPlayers()
        {
            Console.WriteLine("Server is waiting for players...");
        }
    }
}