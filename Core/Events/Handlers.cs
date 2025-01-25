using System;

namespace سست.Core.Event
{
    public static class Handlers
    {
        public static event Action WaitingForPlayers;
        public static event Action RoundStarted;
        public static event Action<Player> Spawned;
    }
}