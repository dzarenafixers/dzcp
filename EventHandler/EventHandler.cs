using سست.Logging;

namespace سست.EventHandler
{
    public class EventHandler
    {
        public void OnWaitingForPlayers()
        {
            Log.Info("Waiting for players...");
        }

        public void OnRoundStarted()
        {
            Log.Info("Round started!");
        }

        public void OnPlayerSpawned(Player player)
        {
            Log.Info($"Player {player.Name} has spawned!");
        }
    }
}