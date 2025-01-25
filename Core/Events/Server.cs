using سست.Core.Event;

namespace سست.Core.Events
{
    /// <summary>
    /// Represents the game server.
    /// </summary>
    public static class Server
    {
        /// <summary>
        /// Gets a value indicating whether the server is waiting for players.
        /// </summary>
        public static bool IsWaitingForPlayers { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the round has started.
        /// </summary>
        public static bool IsRoundStarted { get; private set; }

        /// <summary>
        /// Simulates the server waiting for players.
        /// </summary>
        public static void WaitForPlayers()
        {
            IsWaitingForPlayers = true;
            IsRoundStarted = false;
            var isWaitingForPlayers = سست.Core.Events.Server.IsWaitingForPlayers;
        }
            /// <summary>
        /// Simulates the round starting.
        /// </summary>
        public static void StartRound()
        {
            IsWaitingForPlayers = false;
            IsRoundStarted = true;
            var isRoundStarted = سست.Core.Events.Server.IsRoundStarted;
        } 
    }
}