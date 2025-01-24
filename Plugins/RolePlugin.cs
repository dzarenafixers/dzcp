using DZCP.Core;
using DZCP.API;
using DZCP.Logging;

namespace DZCP.Plugins
{
    public class RolePlugin : IDZCPPlugin
    {
        public void OnEnabled()
        {
            Logger.Info("RolePlugin", "Role Plugin Enabled!");
            EventManager.OnPlayerJoin += OnPlayerJoin;
        }

        public void OnDisabled()
        {
            Logger.Info("RolePlugin", "Role Plugin Disabled!");
            EventManager.OnPlayerJoin -= OnPlayerJoin;
        }

        private void OnPlayerJoin(string playerName)
        {
            Logger.Info("RolePlugin", $"{playerName} joined the game!");
            RoleAPI.AssignRole(playerName, "Class-D");
        }
    }
}