using System;
using DZCP.Core;

namespace DZCP.Plugins
{
    public class ExamplePlugin : IDZCPPlugin
    {
        public void OnEnabled()
        {
            Console.WriteLine("Example Plugin Enabled!");
            EventManager.OnPlayerJoin += OnPlayerJoin;
        }

        public void OnDisabled()
        {
            Console.WriteLine("Example Plugin Disabled!");
            EventManager.OnPlayerJoin -= OnPlayerJoin;
        }

        private void OnPlayerJoin(string playerName)
        {
            Console.WriteLine($"{playerName} joined the game!");
        }
    }
}