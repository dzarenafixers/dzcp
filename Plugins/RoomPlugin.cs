using DZCP.Core;
using DZCP.API;
using DZCP.Logging;

namespace DZCP.Plugins
{
    public class RoomPlugin : IDZCPPlugin
    {
        public void OnEnabled()
        {
            Logger.Info("RoomPlugin", "Room Plugin Enabled!");
            EventManager.OnPlayerJoin += OnPlayerJoin;
        }

        public void OnDisabled()
        {
            Logger.Info("RoomPlugin", "Room Plugin Disabled!");
            EventManager.OnPlayerJoin -= OnPlayerJoin;
        }

        private void OnPlayerJoin(string playerName)
        {
            Logger.Info("RoomPlugin", $"{playerName} joined the game!");
            RoomAPI.TeleportPlayerToRoom(playerName, "LCZ_372");
        }
    }
}